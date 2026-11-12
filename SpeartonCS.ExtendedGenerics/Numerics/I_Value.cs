namespace SpeartonCS.ExtendedGenerics.Numerics;

public interface IZeroValue<TSelf>
    where TSelf : IZeroValue<TSelf>, allows ref struct
{
    public abstract static TSelf Zero { get; }
}

public interface IOneValue<TSelf>
    where TSelf : IOneValue<TSelf>, allows ref struct
{
    public abstract static TSelf One { get; }
}
public interface INegativeOneValue<TSelf>
    where TSelf : INegativeOneValue<TSelf>, allows ref struct
{
    public abstract static TSelf NegativeOne { get; }
}

public interface IMinValue<TSelf>
    where TSelf : IMinValue<TSelf>, allows ref struct
{
    public abstract static TSelf MinValue { get; }
}
public interface IMaxValue<TSelf>
    where TSelf : IMaxValue<TSelf>, allows ref struct
{
    public abstract static TSelf MaxValue { get; }
}

public interface IAllBitsSetValue<TSelf>
    where TSelf : IAllBitsSetValue<TSelf>, allows ref struct
{
    public abstract static TSelf AllBitsSet { get; }
}