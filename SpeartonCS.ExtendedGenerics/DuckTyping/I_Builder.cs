using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.DuckTyping;

public interface IAsyncMethodBuilder<out TBuilder, out TTask>
    where TBuilder : IAsyncMethodBuilder<TBuilder, TTask>
{
    public static abstract TBuilder Create();

    public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;

    public void SetStateMachine(IAsyncStateMachine stateMachine);
    public void SetResult();
    public void SetException(Exception exception);

    public TTask Task { get; }

    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine;
    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachine : IAsyncStateMachine;
}

public interface IAsyncMethodBuilder<out TBuilder, out TTask, in TResult>
    where TBuilder : IAsyncMethodBuilder<TBuilder, TTask, TResult>
{
    public static abstract TBuilder Create();

    public void Start<TStateMachine>(ref TStateMachine stateMachine)
        where TStateMachine : IAsyncStateMachine;

    public void SetStateMachine(IAsyncStateMachine stateMachine);

    public void SetResult(TResult result);

    public void SetException(Exception exception);

    public TTask Task { get; }

    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine;

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachine : IAsyncStateMachine;
}

public interface ICollectionBuilder<out TCollection, TElement>
    where TCollection : allows ref struct
{
    public abstract static TCollection Create(scoped ReadOnlySpan<TElement> elements);
}

public interface IAsyncIteratorMethodBuilder<out TBuilder>
    where TBuilder : IAsyncIteratorMethodBuilder<TBuilder>
{
    public static abstract TBuilder Create();

    public void MoveNext<TStateMachine>(ref TStateMachine stateMachine)
        where TStateMachine : IAsyncStateMachine;

    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine;

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachine : IAsyncStateMachine;

    public void Complete();
}