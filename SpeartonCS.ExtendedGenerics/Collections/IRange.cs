using System.Numerics;

namespace SpeartonCS.ExtendedGenerics.Collections;

public interface IRange<TSelf, TScalar> : IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>
    where TSelf : IRange<TSelf, TScalar>
    where TScalar : allows ref struct
{
    public TScalar Start { get; }
    public TScalar End { get; }
    public bool Contains(TScalar x);
}
public interface IRange<TSelf, TScalar, TLength> : IRange<TSelf, TScalar>
    where TSelf : IRange<TSelf, TScalar, TLength>
    where TScalar : allows ref struct
    where TLength : allows ref struct
{
    public TLength Length { get; }
}