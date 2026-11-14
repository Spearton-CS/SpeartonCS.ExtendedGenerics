using System.Collections;
using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.Collections;

#region IEnumerator

public interface IReadOnlyRefEnumerator<T> : IEnumerator<T>
    where T : allows ref struct
{
    public new ref readonly T Current { get; }
    T IEnumerator<T>.Current
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Current;
    }
}

public interface IRefEnumerator<T> : IReadOnlyRefEnumerator<T>
    where T : allows ref struct
{
    public new ref T Current { get; }
    ref readonly T IReadOnlyRefEnumerator<T>.Current
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref Current;
    }
}

#endregion

#region IAsyncEnumerator

public interface IAsyncReadOnlyRefEnumerator<T> : IAsyncEnumerator<T>
    where T : allows ref struct
{
    public new ref readonly T Current { get; }
    T IAsyncEnumerator<T>.Current
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Current;
    }
}

public interface IAsyncRefEnumerator<T> : IAsyncReadOnlyRefEnumerator<T>
    where T : allows ref struct
{
    public new ref T Current { get; }
    ref readonly T IAsyncReadOnlyRefEnumerator<T>.Current
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref Current;
    }
}

#endregion

#region IEnumerable

public interface IEnumerable<out T, out TEnumerator> : IEnumerable<T>
    where T : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct
{
    public new TEnumerator GetEnumerator();
}

public interface IReadOnlyRefEnumerable<T> : IEnumerable<T>
    where T : allows ref struct
{
    public new IReadOnlyRefEnumerator<T> GetEnumerator();
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
public interface IReadOnlyRefEnumerable<T, out TEnumerator> : IReadOnlyRefEnumerable<T>, IEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TEnumerator : IReadOnlyRefEnumerator<T>, allows ref struct;

public interface IRefEnumerable<T> : IReadOnlyRefEnumerable<T>
    where T : allows ref struct
{
    public new IRefEnumerator<T> GetEnumerator();
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IReadOnlyRefEnumerator<T> IReadOnlyRefEnumerable<T>.GetEnumerator() => GetEnumerator();
}
public interface IRefEnumerable<T, out TEnumerator> : IRefEnumerable<T>, IReadOnlyRefEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TEnumerator : IRefEnumerator<T>, allows ref struct;

#endregion

#region IAsyncEnumerable

public interface IAsyncEnumerable<out T, out TEnumerator> : IAsyncEnumerable<T>
    where T : allows ref struct
    where TEnumerator : IAsyncEnumerator<T>, allows ref struct
{
    public new TEnumerator GetAsyncEnumerator(CancellationToken cancellationToken);
}

public interface IAsyncReadOnlyRefEnumerable<T> : IAsyncEnumerable<T>
    where T : allows ref struct
{
    public new IAsyncReadOnlyRefEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IAsyncEnumerator<T> IAsyncEnumerable<T>.GetAsyncEnumerator(CancellationToken cancellationToken) => GetAsyncEnumerator(cancellationToken);
}
public interface IAsyncReadOnlyRefEnumerable<T, out TEnumerator> : IAsyncReadOnlyRefEnumerable<T>, IAsyncEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TEnumerator : IAsyncReadOnlyRefEnumerator<T>, allows ref struct;

public interface IAsyncRefEnumerable<T> : IAsyncReadOnlyRefEnumerable<T>
    where T : allows ref struct
{
    public new IAsyncRefEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IAsyncReadOnlyRefEnumerator<T> IAsyncReadOnlyRefEnumerable<T>.GetAsyncEnumerator(CancellationToken cancellationToken) => GetAsyncEnumerator(cancellationToken);
}
public interface IAsyncRefEnumerable<T, out TEnumerator> : IAsyncRefEnumerable<T>, IAsyncReadOnlyRefEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TEnumerator : IAsyncRefEnumerator<T>, allows ref struct;

#endregion