namespace SpeartonCS.ExtendedGenerics;

public interface INullValue<TSelf>
    where TSelf : INullValue<TSelf>, allows ref struct
{
    public abstract static TSelf Null { get; }
}