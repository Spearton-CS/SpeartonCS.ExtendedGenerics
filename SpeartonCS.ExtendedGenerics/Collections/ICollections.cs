using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.Collections;

#region ICollection

public interface IReadOnlyCollection<TElement, out TCount>
    : IEnumerable<TElement>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public TCount Count { get; }

    public TCount Capacity { get; }

    public bool IsEmpty { get; }

    public bool Contains(scoped TElement element);
}

public interface IReadOnlyCollection<TElement, out TCount, out TEnumerator>
    : IReadOnlyCollection<TElement, TCount>, IEnumerable<TElement, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IReadOnlyCollection<TElement, out TCount, out TEnumerator, in TIndex>
    : IReadOnlyCollection<TElement, TCount, TEnumerator>, IReadOnlyIndexable<TIndex, TElement>
    
    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct;

public interface ICollection<TElement, TCount>
    : IReadOnlyCollection<TElement, TCount>, IClearable

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryAdd(scoped TElement element);
    public bool TryRemove(scoped TElement element);

    public bool TryRemoveAll(scoped TElement element);
    public bool TryRemoveAll(scoped TElement element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount);
}

public interface ICollection<TElement, TCount, out TEnumerator>
    : ICollection<TElement, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface ICollection<TElement, TCount, out TEnumerator, in TIndex>
    : ICollection<TElement, TCount, TEnumerator>, IReadOnlyCollection<TElement, TCount, TEnumerator, TIndex>, IIndexable<TIndex, TElement>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct
{
    public bool TryRemoveAt(scoped TIndex index);
    public bool TryRemoveAt(scoped TIndex index, [MaybeNullWhen(false)] out TElement? oldElement);
}

#endregion

#region IList

public interface IReadOnlyList<TElement, out TCount, out TEnumerator, TIndex>
    : IReadOnlyCollection<TElement, TCount, TEnumerator, TIndex>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct
{
    public bool TryIndexOf(scoped TElement element, [MaybeNullWhen(false)] out TIndex? index);
}

public interface IList<TElement, TCount, out TEnumerator, TIndex>
    : IReadOnlyList<TElement, TCount, TEnumerator, TIndex>, ICollection<TElement, TCount, TEnumerator, TIndex>, IClearable

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct
{
    public bool TryInsert(scoped TElement element, scoped TIndex index);
    public bool TryInsert(scoped TElement element, scoped TIndex index, [MaybeNullWhen(false)] out TElement? oldElement);
}

#endregion

#region IStack

public interface IReadOnlyStack<TElement, out TCount>
    : IReadOnlyCollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryPeek([MaybeNullWhen(false)] out TElement? element);
}

public interface IReadOnlyStack<TElement, out TCount, out TEnumerator>
    : IReadOnlyStack<TElement, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IStack<TElement, TCount>
    : IReadOnlyStack<TElement, TCount>, ICollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryPush(scoped TElement element);
    public bool TryPop([MaybeNullWhen(false)] out TElement? element);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryAdd(scoped TElement element) => TryPush(element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemove(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return false;
    }
}

public interface IStack<TElement, TCount, out TEnumerator>
    : IStack<TElement, TCount>, IReadOnlyStack<TElement, TCount, TEnumerator>, ICollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

#endregion

#region IQueue

public interface IReadOnlyQueue<TElement, out TCount>
    : IReadOnlyCollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryPeek([MaybeNullWhen(false)] out TElement? element);
}

public interface IReadOnlyQueue<TElement, out TCount, out TEnumerator>
    : IReadOnlyQueue<TElement, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IQueue<TElement, TCount>
    : IReadOnlyQueue<TElement, TCount>, ICollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryEnqueue(scoped TElement element);
    public bool TryDequeue([MaybeNullWhen(false)] out TElement? element);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryAdd(scoped TElement element) => TryEnqueue(element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemove(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return false;
    }
}

public interface IQueue<TElement, TCount, out TEnumerator>
    : IQueue<TElement, TCount>, IReadOnlyQueue<TElement, TCount, TEnumerator>, ICollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

#endregion

#region IDeque

public interface IReadOnlyDeque<TElement, out TCount>
    : IReadOnlyStack<TElement, TCount>, IReadOnlyQueue<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool TryPeekFirst([MaybeNullWhen(false)] out TElement? element);
    public bool TryPeekLast([MaybeNullWhen(false)] out TElement? element);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyStack<TElement, TCount>.TryPeek([MaybeNullWhen(false)] out TElement? element) => TryPeekLast(out element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyQueue<TElement, TCount>.TryPeek([MaybeNullWhen(false)] out TElement? element) => TryPeekFirst(out element);
}

public interface IReadOnlyDeque<TElement, out TCount, out TEnumerator>
    : IReadOnlyDeque<TElement, TCount>, IReadOnlyStack<TElement, TCount, TEnumerator>, IReadOnlyQueue<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IDeque<TElement, TCount>
    : IReadOnlyDeque<TElement, TCount>, IStack<TElement, TCount>, IQueue<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryAdd(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemove(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemoveAll(scoped TElement element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return false;
    }
}

public interface IDeque<TElement, TCount, out TEnumerator>
    : IDeque<TElement, TCount>, IReadOnlyDeque<TElement, TCount, TEnumerator>, IStack<TElement, TCount, TEnumerator>, IQueue<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

#endregion

#region Dictionary

public interface IReadOnlyDictionary<TKey, TValue, out TCount>
    : IReadOnlyCollection<TKey, TCount>, IReadOnlyIndexable<TKey, TValue>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
{
    public bool ContainsKey(scoped TKey key);
    public bool ContainsValue(scoped TValue value);

    public bool TryGetKeyOf(scoped TValue value, [MaybeNullWhen(false)] out TKey key);

    public bool TryGetValue(scoped TKey key, [MaybeNullWhen(false)] out TValue? value);

    public IEnumerable<TValue> GetValueEnumerable();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyCollection<TKey, TCount>.Contains(scoped TKey element) => ContainsKey(element);
}

public interface IReadOnlyDictionary<TKey, TValue, out TCount, out TEnumerator>
    : IReadOnlyDictionary<TKey, TValue, TCount>, IReadOnlyCollection<TKey, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface IReadOnlyDictionary<TKey, TValue, out TCount, out TEnumerator, out TValueEnumerable>
    : IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue>, allows ref struct
{
    public TValueEnumerable GetValueEnumerable();
}

public interface IReadOnlyDictionary<TKey, TValue, out TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct;

public interface IDictionary<TKey, TValue, TCount>
    : IReadOnlyDictionary<TKey, TValue, TCount>, ICollection<TKey, TCount>, IIndexable<TKey, TValue>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
{
    public bool TryAdd(scoped TKey key, scoped TValue value);

    public bool TryRemoveKey(scoped TKey key);
    public bool TryRemoveKey(scoped TKey key, [MaybeNullWhen(false)] out TValue? value);

    public bool TryRemoveKeysByValue(scoped TValue value);
    public bool TryRemoveKeysByValue(scoped TValue value, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryAdd(scoped TKey element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemove(scoped TKey element) => TryRemoveKey(element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return false;
    }
}

public interface IDictionary<TKey, TValue, TCount, out TEnumerator>
    : IDictionary<TKey, TValue, TCount>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface IDictionary<TKey, TValue, TCount, out TEnumerator, out TValueEnumerable>
    : IDictionary<TKey, TValue, TCount, TEnumerator>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue>, allows ref struct;

public interface IDictionary<TKey, TValue, TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct;

#endregion

#region Map

#endregion