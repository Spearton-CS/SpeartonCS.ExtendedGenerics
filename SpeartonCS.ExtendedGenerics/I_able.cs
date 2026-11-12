using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics;

public interface ICloneable<TSelf>
    where TSelf : ICloneable<TSelf>, allows ref struct
{
    public TSelf Clone();
    public void Clone(out TSelf clone);
}

#region fixed (...)

public interface IPinnable<TPinnedReference>
    where TPinnedReference : IPinnable<TPinnedReference>, allows ref struct
{
    public ref TPinnedReference GetPinnableReference();
}

#endregion

#region await ...

public interface IAwaiter : ICriticalNotifyCompletion
{
    public bool IsCompleted { get; }
    public void GetResult();
}
public interface IAwaiter<out TResult> : IAwaiter
    where TResult : allows ref struct
{
    public new TResult GetResult();
    void IAwaiter.GetResult() => GetResult();
}

public interface IAwaitable
{
    public IAwaiter GetAwaiter();
}
public interface IAwaitable<out TAwaiter> : IAwaitable
    where TAwaiter : IAwaiter, allows ref struct
{
    public new TAwaiter GetAwaiter();
}
public interface IAwaitable<out TAwaiter, out TResult> : IAwaitable<TAwaiter>
    where TAwaiter : IAwaiter<TResult>, allows ref struct
    where TResult : allows ref struct;

#endregion