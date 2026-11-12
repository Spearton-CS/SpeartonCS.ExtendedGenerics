namespace SpeartonCS.ExtendedGenerics.Collections;

public interface IResetable
{
    public void Reset();
}

public interface IClearable
{
    public void Clear();
}

public interface IEnumerable<out T, out TEnumerator> : IEnumerable<T>
    where T : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct
{
    public new TEnumerator GetEnumerator();
}

public interface IReadOnlyIndexable<in TIndex, out TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public TResult this[TIndex index] { get; }
}
public interface IReadOnlyRefIndexable<in TIndex, TResult> : IReadOnlyIndexable<TIndex, TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public new ref readonly TResult this[TIndex index] { get; }
    TResult IReadOnlyIndexable<TIndex, TResult>.this[TIndex index] => this[index];
}

public interface IIndexable<in TIndex, TResult> : IReadOnlyIndexable<TIndex, TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public new TResult this[TIndex index] { get; set; }
    TResult IReadOnlyIndexable<TIndex, TResult>.this[TIndex index] => this[index];
}

public interface IRefIndexable<in TIndex, TResult> : IIndexable<TIndex, TResult>, IReadOnlyRefIndexable<TIndex, TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public new ref TResult this[TIndex index] { get; }
    TResult IReadOnlyIndexable<TIndex, TResult>.this[TIndex index] => this[index];
    ref readonly TResult IReadOnlyRefIndexable<TIndex, TResult>.this[TIndex index] => ref this[index];
    TResult IIndexable<TIndex, TResult>.this[TIndex index]
    {
        get => this[index];
        set => this[index] = value;
    }
}