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

public interface IIndexable<in TIndex, TResult> : IReadOnlyIndexable<TIndex, TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public new TResult this[TIndex index] { get; set; }
    TResult IReadOnlyIndexable<TIndex, TResult>.this[TIndex index] => this[index];
}