namespace SpeartonCS.ExtendedGenerics.Collections;

#region IReadOnlyCollection

public interface IReadOnlyCollection<out TElement, out TCount>
    : IEnumerable<TElement>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public TCount Count { get; }
}

public interface IReadOnlyCollection<out TElement, out TCount, out TEnumerator>
    : IReadOnlyCollection<TElement, TCount>, IEnumerable<TElement, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IReadOnlyCollection<out TElement, out TCount, out TEnumerator, in TIndex>
    : IReadOnlyCollection<TElement, TCount, TEnumerator>, IReadOnlyIndexable<TIndex, TElement>
    
    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct;

#endregion

#region ICollection

public interface ICollection<TElement, out TCount>
    : IReadOnlyCollection<TElement, TCount>, IClearable

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public void Add(scoped TElement element);
    public bool TryRemove(scoped TElement element);
    public bool Contains(scoped TElement element);
}

public interface ICollection<TElement, out TCount, out TEnumerator>
    : ICollection<TElement, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface ICollection<TElement, out TCount, out TEnumerator, in TIndex>
    : ICollection<TElement, TCount, TEnumerator>, IReadOnlyCollection<TElement, TCount, TEnumerator, TIndex>, IIndexable<TIndex, TElement>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct
{
    public TElement RemoveAt(scoped TIndex index);
}

#endregion

