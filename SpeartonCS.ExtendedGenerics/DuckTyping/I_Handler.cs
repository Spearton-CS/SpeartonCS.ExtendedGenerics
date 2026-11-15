namespace SpeartonCS.ExtendedGenerics.DuckTyping;

public interface IInterpolatedStringLiteralHandler
{
    public void AppendLiteral(string s);
}

public interface IInterpolatedStringTHandler
{
    public void AppendFormatted<T>(scoped T value) where T : allows ref struct;
    public void AppendFormatted<T>(scoped T value, string? format) where T : allows ref struct;
    public void AppendFormatted<T>(scoped T value, int alignment) where T : allows ref struct;
    public void AppendFormatted<T>(scoped T value, int alignment, string? format) where T : allows ref struct;
}
public interface IInterpolatedStringTHandler<T>
    where T : allows ref struct
{
    public void AppendFormatted(scoped T value);
    public void AppendFormatted(scoped T value, string? format);
    public void AppendFormatted(scoped T value, int alignment);
    public void AppendFormatted(scoped T value, int alignment, string? format);
}

public interface IInterpolatedStringSpanHandler
{
    public void AppendFormatted(scoped ReadOnlySpan<char> value);
    public void AppendFormatted(scoped ReadOnlySpan<char> value, int alignment, string? format);
}

public interface IInterpolatedStringHandler : IInterpolatedStringLiteralHandler, IInterpolatedStringTHandler, IInterpolatedStringSpanHandler;