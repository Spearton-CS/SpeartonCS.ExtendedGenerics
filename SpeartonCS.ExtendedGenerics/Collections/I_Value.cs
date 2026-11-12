namespace SpeartonCS.ExtendedGenerics.Collections;

public interface IEmptyValue<TSelf>
    where TSelf : IEmptyValue<TSelf>, allows ref struct
{
    public abstract static TSelf Empty { get; }
}