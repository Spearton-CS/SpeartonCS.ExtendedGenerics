namespace SpeartonCS.ExtendedGenerics.Numerics;

#region Explicit|Implicit

#region Explicit

/// <summary>
/// <typeparamref name="TOther"/> = (<typeparamref name="TOther"/>)<typeparamref name="TSelf"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IExplicitFromOperators<TSelf, TOther>
    where TSelf : IExplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TSelf(TOther other);
}

/// <summary>
/// <typeparamref name="TSelf"/> = (<typeparamref name="TSelf"/>)<typeparamref name="TOther"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IExplicitToOperators<TSelf, TOther>
    where TSelf : IExplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TOther(TSelf other);
}

/// <summary>
/// <typeparamref name="TOther"/> = (<typeparamref name="TOther"/>)<typeparamref name="TSelf"/>, <typeparamref name="TSelf"/> = (<typeparamref name="TSelf"/>)<typeparamref name="TOther"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IExplicitOperators<TSelf, TOther> : IExplicitFromOperators<TSelf, TOther>, IExplicitToOperators<TSelf, TOther>
    where TSelf : IExplicitOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct;

#endregion

#region Implicit

/// <summary>
/// <typeparamref name="TSelf"/> = <typeparamref name="TOther"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IImplicitFromOperators<TSelf, TOther>
    where TSelf : IImplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TSelf(TOther other);
}

/// <summary>
/// <typeparamref name="TOther"/> = <typeparamref name="TSelf"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IImplicitToOperators<TSelf, TOther>
    where TSelf : IImplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TOther(TSelf other);
}

/// <summary>
/// <typeparamref name="TOther"/> = <typeparamref name="TSelf"/>, <typeparamref name="TSelf"/> = <typeparamref name="TOther"/>
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TOther"></typeparam>
public interface IImplicitOperators<TSelf, TOther> : IImplicitFromOperators<TSelf, TOther>, IImplicitToOperators<TSelf, TOther>
    where TSelf : IImplicitOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct;

#endregion

#endregion

#region Shift

public interface ILeftShiftOperators<TSelf, TShift, TResult>
    where TSelf : ILeftShiftOperators<TSelf, TShift, TResult>, allows ref struct
    where TShift : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator <<(TSelf self, TShift shift);
}

public interface IRightShiftOperators<TSelf, TShift, TResult>
    where TSelf : IRightShiftOperators<TSelf, TShift, TResult>, allows ref struct
    where TShift : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator >>(TSelf self, TShift shift);
}

public interface IURightShiftOperators<TSelf, TShift, TResult>
    where TSelf : IURightShiftOperators<TSelf, TShift, TResult>, allows ref struct
    where TShift : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator >>>(TSelf self, TShift shift);
}

#endregion

#region Bitwise

public interface IBitwiseAndOperators<TSelf, TOther, TResult>
    where TSelf : IBitwiseAndOperators<TSelf, TOther, TResult>, allows ref struct
    where TOther : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator &(TSelf self, TOther other);
}

public interface IBitwiseOrOperators<TSelf, TOther, TResult>
    where TSelf : IBitwiseOrOperators<TSelf, TOther, TResult>, allows ref struct
    where TOther : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator |(TSelf self, TOther other);
}

public interface IBitwiseXorOperators<TSelf, TOther, TResult>
    where TSelf : IBitwiseXorOperators<TSelf, TOther, TResult>, allows ref struct
    where TOther : allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator ^(TSelf self, TOther other);
}

public interface IBitwiseNotOperators<TSelf, TResult>
    where TSelf : IBitwiseNotOperators<TSelf, TResult>, allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator ~(TSelf self);
}

#endregion

#region Logical

public interface ILogicalNotOperators<TSelf, TResult>
    where TSelf : ILogicalNotOperators<TSelf, TResult>, allows ref struct
    where TResult : allows ref struct
{
    public abstract static TResult operator !(TSelf self);
}

/// <summary>
/// if (<typeparamref name="TSelf"/>) and if (!<typeparamref name="TSelf"/>)
/// </summary>
/// <typeparam name="TSelf"></typeparam>
public interface ITrueFalseOperators<TSelf>
    where TSelf : ITrueFalseOperators<TSelf>, allows ref struct
{
    public abstract static bool operator true(TSelf self);
    public abstract static bool operator false(TSelf self);
}

/// <summary>
/// if (.. <![CDATA[&&]]> <typeparamref name="TSelf"/>) and if (.. <![CDATA[||]]> <typeparamref name="TSelf"/>)
/// </summary>
/// <typeparam name="TSelf"></typeparam>
public interface IConditionalLogicalOperators<TSelf> : ITrueFalseOperators<TSelf>, IBitwiseAndOperators<TSelf, TSelf, TSelf>, IBitwiseOrOperators<TSelf, TSelf, TSelf>
    where TSelf : IConditionalLogicalOperators<TSelf>, allows ref struct;

#endregion