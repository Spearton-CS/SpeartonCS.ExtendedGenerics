namespace SpeartonCS.ExtendedGenerics;

public interface ICloneable<TSelf>
    where TSelf : ICloneable<TSelf>, allows ref struct
{
    public TSelf Clone();
    public void Clone(out TSelf clone);
}