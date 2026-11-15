using System.Text.RegularExpressions;

using SpeartonCS.ExtendedGenerics;

using StreamWriter writer = new(File.Open("ExportTypeList.md", FileMode.Create, FileAccess.Write, FileShare.Read));
DisplayTypes(writer);

static void DisplayTypes(StreamWriter writer)
{
    Namespace root = new("SpeartonCS");

    foreach (Type type in typeof(INullValue<>).Assembly.GetTypes())
    {
        if (type.Namespace is null || !type.IsPublic || !type.Namespace.StartsWith("SpeartonCS", StringComparison.Ordinal))
            continue;

        Namespace current = root;

        if (type.Namespace.Length > "SpeartonCS".Length)
        {
            string relativeNs = type.Namespace[("SpeartonCS".Length + 1)..];
            foreach (string part in relativeNs.Split('.'))
            {
                Namespace? next = current.Subnamespaces.Find(n => n.Name == part);
                if (next is null)
                {
                    next = new Namespace(part);
                    current.Subnamespaces.Add(next);
                }
                current = next;
            }
        }

        string baseName = type.Name;
        int tickIndex = baseName.IndexOf('`');
        if (tickIndex >= 0) baseName = baseName[..tickIndex];

        TypeGroup? group = current.TypeGroups.Find(g => g.BaseName == baseName);
        if (group is null)
        {
            group = new TypeGroup { BaseName = baseName };
            current.TypeGroups.Add(group);
        }

        if (type.IsGenericType)
            group.GenericOverloads.Add(type);
        else
            group.NonGenericKind = GetKind(type);
    }

    PrintTreeConsole(root, "", isLast: true, isRoot: true);

    writer.WriteLine("# SpeartonCS API Reference\n");
    PrintTreeMarkdown(root, writer, "");
}

static List<(string Kind, string FormattedName)> GetFormattedOverloads(TypeGroup group)
{
    var result = new List<(string Kind, string FormattedName)>();
    if (group.NonGenericKind != null)
        result.Add((group.NonGenericKind, group.BaseName));

    var seqGroups = new Dictionary<string, (string Kind, string Prefix, int Min, int Max, string Mask)>();
    var standalone = new List<(string Kind, string FormattedName)>();

    foreach (var t in group.GenericOverloads)
    {
        var args = t.GetGenericArguments().Select(a => a.Name).ToArray();
        bool foundSeq = false;

        for (int i = 0; i < args.Length; i++)
        {
            var match = Regex.Match(args[i], @"^([a-zA-Z]+)(\d+)$");
            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                int start = int.Parse(match.Groups[2].Value);
                int current = start;
                int j = i + 1;

                while (j < args.Length)
                {
                    var m2 = Regex.Match(args[j], @"^([a-zA-Z]+)(\d+)$");
                    if (m2.Success && m2.Groups[1].Value == prefix && int.Parse(m2.Groups[2].Value) == current + 1)
                    {
                        current++;
                        j++;
                    }
                    else break;
                }

                string mask = string.Join(", ", args.Take(i)) +
                                (i > 0 ? ", " : "") +
                                "{SEQ}" +
                                (j < args.Length ? ", " : "") +
                                string.Join(", ", args.Skip(j));

                string kind = GetKind(t);
                string key = kind + "||" + mask;

                if (!seqGroups.ContainsKey(key))
                    seqGroups[key] = (kind, prefix, start, current, mask);
                else
                {
                    var existing = seqGroups[key];
                    seqGroups[key] = (kind, prefix, Math.Min(existing.Min, start), Math.Max(existing.Max, current), mask);
                }

                foundSeq = true;
                break;
            }
        }

        if (!foundSeq)
            standalone.Add((GetKind(t), $"{group.BaseName}<{string.Join(", ", args)}>"));
    }

    foreach (var sg in seqGroups.Values)
    {
        string seqStr = sg.Max > sg.Min ? $"{sg.Prefix}{sg.Min}..{sg.Prefix}{sg.Max}" : $"{sg.Prefix}{sg.Min}";
        string finalArgs = sg.Mask.Replace("{SEQ}", seqStr);
        result.Add((sg.Kind, $"{group.BaseName}<{finalArgs}>"));
    }

    result.AddRange(standalone);
    return result.OrderBy(x => x.FormattedName.Length).ThenBy(x => x.FormattedName).ToList();
}

static void PrintTreeConsole(Namespace ns, string indent, bool isLast, bool isRoot)
{
    if (isRoot)
    {
        Console.WriteLine(ns.Name);
    }
    else
    {
        Console.WriteLine($"{indent}{(isLast ? "└── " : "├── ")}{ns.Name}");
        indent += isLast ? "    " : "│   ";
    }

    var orderedSub = ns.Subnamespaces.OrderBy(s => s.Name, StringComparer.Ordinal).ToList();
    var orderedGroups = ns.TypeGroups.OrderBy(g => g.BaseName, StringComparer.Ordinal).ToList();

    int totalItems = orderedSub.Count + orderedGroups.Count;
    int index = 0;

    foreach (var sub in orderedSub)
    {
        bool lastItem = ++index == totalItems;
        PrintTreeConsole(sub, indent, lastItem, isRoot: false);
    }

    foreach (var group in orderedGroups)
    {
        bool lastItem = ++index == totalItems;
        string branch = lastItem ? "└── " : "├── ";

        var overloads = GetFormattedOverloads(group);

        if (overloads.Count == 1)
        {
            Console.WriteLine($"{indent}{branch}[{overloads[0].Kind}] {overloads[0].FormattedName}");
        }
        else
        {
            string suffix = group.NonGenericKind is null ? "<..>" : "";
            Console.WriteLine($"{indent}{branch}[{overloads[0].Kind}] {group.BaseName}{suffix}");

            string childIndent = indent + (lastItem ? "    " : "│   ");
            for (int i = 0; i < overloads.Count; i++)
            {
                bool childLast = (i == overloads.Count - 1);
                Console.WriteLine($"{childIndent}{(childLast ? "└── " : "├── ")}[{overloads[i].Kind}] {overloads[i].FormattedName}");
            }
        }
    }
}

static void PrintTreeMarkdown(Namespace ns, StreamWriter writer, string currentPath)
{
    string path = string.IsNullOrEmpty(currentPath) ? ns.Name : $"{currentPath}.{ns.Name}";

    if (ns.TypeGroups.Count > 0)
    {
        writer.WriteLine($"## {path}");
        writer.WriteLine();
        writer.WriteLine("| Kind | Type |");
        writer.WriteLine("| :--- | :--- |");

        var orderedGroups = ns.TypeGroups.OrderBy(g => g.BaseName, StringComparer.Ordinal).ToList();

        foreach (var group in orderedGroups)
        {
            var overloads = GetFormattedOverloads(group);

            if (overloads.Count == 1)
            {
                writer.WriteLine($"| `{overloads[0].Kind}` | `{overloads[0].FormattedName}` |");
            }
            else
            {
                string suffix = group.NonGenericKind is null ? " `<..>`" : "";
                string overloadsHtml = string.Join("<br>", overloads.Select(o => $"&nbsp;&nbsp;↳ `[{o.Kind}] {o.FormattedName}`"));
                writer.WriteLine($"| `{overloads[0].Kind}` | **`{group.BaseName}`**{suffix}<br>{overloadsHtml} |");
            }
        }
        writer.WriteLine();
    }

    var orderedSub = ns.Subnamespaces.OrderBy(s => s.Name, StringComparer.Ordinal).ToList();

    foreach (var sub in orderedSub)
    {
        PrintTreeMarkdown(sub, writer, path);
    }
}

static string GetKind(Type t)
{
    if (t.IsInterface) return "interface";
    if (t.IsEnum) return "enum";
    if (typeof(MulticastDelegate).IsAssignableFrom(t.BaseType)) return "delegate";
    if (t.IsValueType)
    {
        return (t.CustomAttributes.Any(a => a.AttributeType.FullName == "System.Runtime.CompilerServices.IsReadOnlyAttribute"), t.IsByRefLike) switch
        {
            (true, true) => "readonly ref struct",
            (false, true) => "ref struct",
            (true, false) => "readonly struct",
            _ => "struct"
        };
    }
    if (t.IsAbstract && t.IsSealed) return "static class";
    if (t.IsAbstract) return "abstract class";
    if (t.IsSealed) return "sealed class";
    return "class";
}

sealed record Namespace(string Name)
{
    public List<Namespace> Subnamespaces { get; } = new();
    public List<TypeGroup> TypeGroups { get; } = new();
}

sealed class TypeGroup
{
    public string BaseName { get; init; } = "";
    public string? NonGenericKind { get; set; }
    public List<Type> GenericOverloads { get; } = new();
}