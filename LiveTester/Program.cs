using SpeartonCS.ExtendedGenerics;

namespace LiveTester;

internal class Program
{
    static void Main(string[] args)
    {
        DisplayTypes();

        static void DisplayTypes()
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

                current.Types.Add((FormatName(type), GetKind(type)));
            }

            PrintTree(root, "", isLast: true, isRoot: true);
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

        static string FormatName(Type t)
        {
            if (!t.IsGenericType)
                return t.Name;

            int tickIndex = t.Name.IndexOf('`');
            string baseName = tickIndex >= 0 ? t.Name[..tickIndex] : t.Name;
            string argsList = string.Join(", ", t.GetGenericArguments().Select(a => a.Name));
            return $"{baseName}<{argsList}>";
        }

        static void PrintTree(Namespace ns, string indent, bool isLast, bool isRoot)
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
            var orderedTypes = ns.Types.OrderBy(t => t.Name, StringComparer.Ordinal).ToList();

            int totalItems = orderedSub.Count + orderedTypes.Count;
            int index = 0;

            foreach (var sub in orderedSub)
            {
                bool lastItem = ++index == totalItems;
                PrintTree(sub, indent, lastItem, isRoot: false);
            }

            foreach (var (name, kind) in orderedTypes)
            {
                bool lastItem = ++index == totalItems;
                string branch = lastItem ? "└── " : "├── ";
                Console.WriteLine($"{indent}{branch}[{kind}] {name}");
            }
        }
    }
    
    record Namespace(string Name)
    {
        public readonly List<Namespace> Subnamespaces = [];
        public readonly List<(string Name, string Kind)> Types = []; 
    }
}