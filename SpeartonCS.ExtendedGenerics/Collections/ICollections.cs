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
    : IReadOnlyList<TElement, TCount, TEnumerator, TIndex>, ICollection<TElement, TCount, TEnumerator, TIndex>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TIndex : allows ref struct
{
    public bool TryInsert(scoped TElement element, scoped TIndex index);
    public bool TryInsert(scoped TElement element, scoped TIndex index, [MaybeNullWhen(false)] out TElement? oldElement);
}

#endregion

#region LinkedList

#region Nodes

public interface IReadOnlyLinkedNode<TElement>
    where TElement : allows ref struct
{
    public TElement Value { get; }

    public bool TryGetPrevious([MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? prev);
    public bool TryGetNext([MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? prev);
}

public interface IReadOnlyLinkedNode<TSelf, TElement>
    : IReadOnlyLinkedNode<TElement>

    where TSelf : IReadOnlyLinkedNode<TSelf, TElement>, allows ref struct
    where TElement : allows ref struct
{
    public bool TryGetPrevious([MaybeNullWhen(false)] out TSelf? prev);
    public bool TryGetNext([MaybeNullWhen(false)] out TSelf? prev);
}

public interface ILinkedNode<TElement>
    : IReadOnlyLinkedNode<TElement>

    where TElement : allows ref struct
{
    public TElement Value { get; set; }

    public bool TryGetPrevious([MaybeNullWhen(false)] out ILinkedNode<TElement>? prev);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyLinkedNode<TElement>.TryGetPrevious(out IReadOnlyLinkedNode<TElement>? prev) => TryGetPrevious(out prev);
    public bool TrySetPrevious([MaybeNull] ILinkedNode<TElement>? prev);
    public bool TrySetPrevious([MaybeNull] ILinkedNode<TElement>? prev, [MaybeNullWhen(false)] out ILinkedNode<TElement>? old);
    public bool TryRemovePrevious();

    public bool TryGetNext([MaybeNullWhen(false)] out ILinkedNode<TElement>? prev);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyLinkedNode<TElement>.TryGetNext(out IReadOnlyLinkedNode<TElement>? next) => TryGetNext(out next);
    public bool TrySetNext([MaybeNull] ILinkedNode<TElement>? next);
    public bool TrySetNext([MaybeNull] ILinkedNode<TElement>? next, [MaybeNullWhen(false)] out ILinkedNode<TElement>? old);
    public bool TryRemoveNext();

    public bool TryMoveAfter(ILinkedNode<TElement> after);
    public bool TryMoveBefore(ILinkedNode<TElement> before);
}

public interface ILinkedNode<TSelf, TElement>
    : ILinkedNode<TElement>, IReadOnlyLinkedNode<TSelf, TElement>

    where TSelf : ILinkedNode<TSelf, TElement>, allows ref struct
    where TElement : allows ref struct
{
    public new bool TrySetPrevious([MaybeNull] scoped TSelf? prev);
    public new bool TrySetPrevious([MaybeNull] scoped TSelf? prev, [MaybeNullWhen(false)] out TSelf? old);

    public new bool TrySetNext([MaybeNull] scoped TSelf? next);
    public new bool TrySetNext([MaybeNull] scoped TSelf? next, [MaybeNullWhen(false)] out TSelf? old);

    public new bool TryMoveAfter(scoped TSelf after);
    public new bool TryMoveBefore(scoped TSelf before);
}

#endregion

#region Lists

public interface IReadOnlyLinkedList<TElement, out TCount>
    : IReadOnlyCollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public bool IsDoubleLinked { get; }
    /// <summary>
    /// When IsDoubleLinked is <see langword="false"/>,
    /// IsForwardDirected <see langword="true"/> means that Node.TryGetNext() probably returns true, otherwise - Node.TryGetPrevious.
    /// </summary>
    public bool IsForwardDirected { get; }

    public IReadOnlyLinkedNode<TElement> FirstNode { get; }
    public bool TryGetLastNode([MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? last);

    public bool TryNodeOf(scoped TElement element, [MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? node);
}

public interface IReadOnlyLinkedList<TElement, out TCount, out TEnumerator>
    : IReadOnlyLinkedList<TElement, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>
    
    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IReadOnlyLinkedList<TElement, out TCount, out TEnumerator, TNode>
    : IReadOnlyLinkedList<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TNode : IReadOnlyLinkedNode<TNode, TElement>, allows ref struct
{
    public new TNode FirstNode { get; }
    public new bool TryGetLastNode([MaybeNullWhen(false)] out TNode? last);

    public new bool TryNodeOf(scoped TElement element, [MaybeNullWhen(false)] out TNode? node);
}

public interface ILinkedList<TElement, TCount>
    : IReadOnlyLinkedList<TElement, TCount>, ICollection<TElement, TCount>

    where TElement : allows ref struct
    where TCount : allows ref struct
{
    public new ILinkedNode<TElement> FirstNode { get; }
    IReadOnlyLinkedNode<TElement> IReadOnlyLinkedList<TElement, TCount>.FirstNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => FirstNode;
    }
    public new bool TryGetLastNode([MaybeNullWhen(false)] out ILinkedNode<TElement>? last);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyLinkedList<TElement, TCount>.TryGetLastNode([MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? last) => TryGetLastNode(out last);

    public new bool TryNodeOf(scoped TElement element, [MaybeNullWhen(false)] out ILinkedNode<TElement>? node);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IReadOnlyLinkedList<TElement, TCount>.TryNodeOf(scoped TElement element, [MaybeNullWhen(false)] out IReadOnlyLinkedNode<TElement>? node) => TryNodeOf(element, out node);

    public bool TryAdd(scoped TElement value, [MaybeNullWhen(false)] out ILinkedNode<TElement>? node);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryAdd(scoped TElement element) => TryAdd(element, out _);

    public bool TryRemove(scoped TElement value, [MaybeNullWhen(false)] out ILinkedNode<TElement>? node);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TElement, TCount>.TryRemove(scoped TElement element) => TryRemove(element, out _);
    public bool TryRemove(ILinkedNode<TElement> node);
    public bool TryRemove(ILinkedNode<TElement> node, [MaybeNullWhen(false)] out TElement? value);

    public bool TryInsert(scoped TElement value, ILinkedNode<TElement> node, [MaybeNullWhen(false)] out ILinkedNode<TElement>? insert);
    public bool TryMoveAfter(ILinkedNode<TElement> node, ILinkedNode<TElement> after);
    public bool TryMoveBefore(ILinkedNode<TElement> node, ILinkedNode<TElement> before);
}

public interface ILinkedList<TElement, TCount, out TEnumerator>
    : ILinkedList<TElement, TCount>, IReadOnlyLinkedList<TElement, TCount, TEnumerator>, ICollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface ILinkedList<TElement, TCount, out TEnumerator, TNode>
    : ILinkedList<TElement, TCount, TEnumerator>, IReadOnlyLinkedList<TElement, TCount, TEnumerator, TNode>

    where TElement : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct
    where TNode : ILinkedNode<TNode, TElement>, allows ref struct
{
    public bool TryAdd(scoped TElement value, [MaybeNullWhen(false)] out TNode? node);

    public bool TryRemove(scoped TElement value, [MaybeNullWhen(false)] out TNode? node);
    public bool TryRemove(scoped TNode node);
    public bool TryRemove(scoped TNode node, [MaybeNullWhen(false)] out TElement? value);

    public bool TryInsert(scoped TElement value, scoped TNode node, [MaybeNullWhen(false)] out TNode? insert);
    public bool TryMoveAfter(scoped TNode node, TNode after);
    public bool TryMoveBefore(scoped TNode node, TNode before);
}

#endregion

#endregion

#region ISet

public interface IReadOnlySet<TKey, out TCount>
    : IReadOnlyCollection<TKey, TCount>

    where TKey : allows ref struct
    where TCount : allows ref struct;

public interface IReadOnlySet<TKey, out TCount, out TEnumerator>
    : IReadOnlySet<TKey, TCount>, IReadOnlyCollection<TKey, TCount, TEnumerator>

    where TKey : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface ISet<TKey, TCount>
    : IReadOnlySet<TKey, TCount>, ICollection<TKey, TCount>

    where TKey : allows ref struct
    where TCount : allows ref struct
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element) => TryRemove(element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return TryRemove(element);
    }
}

public interface ISet<TKey, TCount, out TEnumerator>
    : ISet<TKey, TCount>, IReadOnlySet<TKey, TCount, TEnumerator>, ICollection<TKey, TCount, TEnumerator>

    where TKey : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

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

#region IPriorityQueue

public interface IReadOnlyPriorityQueue<TElement, TPriority, out TCount>
    : IReadOnlyCollection<TElement, TCount>

    where TElement : allows ref struct
    where TPriority : allows ref struct
    where TCount : allows ref struct
{
    public bool TryPeek(scoped TPriority priority, [MaybeNullWhen(false)] out TElement? element);
}

public interface IReadOnlyPriorityQueue<TElement, TPriority, out TCount, out TEnumerator>
    : IReadOnlyPriorityQueue<TElement, TPriority, TCount>, IReadOnlyCollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TPriority : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TElement>, allows ref struct;

public interface IPriorityQueue<TElement, TPriority, TCount>
    : IReadOnlyPriorityQueue<TElement, TPriority, TCount>, ICollection<TElement, TCount>

    where TElement : allows ref struct
    where TPriority : allows ref struct
    where TCount : allows ref struct
{
    public bool TryEnqueue(scoped TPriority priority, scoped TElement element);
    public bool TryDequeue(scoped TPriority priority, [MaybeNullWhen(false)] out TElement? element);

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

public interface IPriorityQueue<TElement, TPriority, TCount, out TEnumerator>
    : IPriorityQueue<TElement, TPriority, TCount>, IReadOnlyPriorityQueue<TElement, TPriority, TCount, TEnumerator>, ICollection<TElement, TCount, TEnumerator>

    where TElement : allows ref struct
    where TPriority : allows ref struct
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

public interface IReadOnlyDictionary<TKey, TValue, out TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct
{
    public new TValueEnumerable GetValueEnumerable();
}

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
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element) => TryRemoveKey(element);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool ICollection<TKey, TCount>.TryRemoveAll(scoped TKey element, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return TryRemoveKey(element);
    }
}

public interface IDictionary<TKey, TValue, TCount, out TEnumerator>
    : IDictionary<TKey, TValue, TCount>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface IDictionary<TKey, TValue, TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IDictionary<TKey, TValue, TCount, TEnumerator>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct;

#endregion

#region Map

public interface IReadOnlyMap<TKey, TValue, out TCount>
    : IReadOnlyDictionary<TKey, TValue, TCount>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
{
    public IReadOnlyMap<TValue, TKey, TCount> AsValueKeyMap();
}

public interface IReadOnlyMap<TKey, TValue, out TCount, out TEnumerator>
    : IReadOnlyMap<TKey, TValue, TCount>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>
    
    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface IReadOnlyMap<TKey, TValue, out TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IReadOnlyMap<TKey, TValue, TCount, TEnumerator>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct
{
    public new IReadOnlyMap<TValue, TKey, TCount, TValueEnumerator> AsValueKeyMap();
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IReadOnlyMap<TValue, TKey, TCount> IReadOnlyMap<TKey, TValue, TCount>.AsValueKeyMap() => AsValueKeyMap();
}

public interface IReadOnlyMap<TKey, TValue, out TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator, out TValueKeyMap>
    : IReadOnlyMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>, IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct
    where TValueKeyMap : IReadOnlyMap<TValue, TKey, TCount, TValueEnumerator>, allows ref struct
{
    public new TValueKeyMap AsValueKeyMap();
}

public interface IMap<TKey, TValue, TCount>
    : IReadOnlyMap<TKey, TValue, TCount>, IDictionary<TKey, TValue, TCount>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
{
    public bool TryRemoveValue(scoped TValue value);
    public bool TryRemoveValue(scoped TValue value, [MaybeNullWhen(false)] out TKey? key);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IDictionary<TKey, TValue, TCount>.TryRemoveKeysByValue(scoped TValue value) => TryRemoveValue(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IDictionary<TKey, TValue, TCount>.TryRemoveKeysByValue(scoped TValue value, [MaybeNullWhen(false)] out TCount? allCount, [MaybeNullWhen(false)] out TCount? removedCount)
    {
        allCount = removedCount = default;
        return TryRemoveValue(value);
    }
}

public interface IMap<TKey, TValue, TCount, out TEnumerator>
    : IMap<TKey, TValue, TCount>, IReadOnlyMap<TKey, TValue, TCount, TEnumerator>, IDictionary<TKey, TValue, TCount, TEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct;

public interface IMap<TKey, TValue, TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator>
    : IMap<TKey, TValue, TCount, TEnumerator>, IReadOnlyMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>,
    IDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct;

public interface IMap<TKey, TValue, TCount, out TEnumerator, out TValueEnumerable, out TValueEnumerator, out TValueKeyMap>
    : IMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>, IReadOnlyMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator, TValueKeyMap>,
    IDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>

    where TKey : allows ref struct
    where TValue : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<TKey>, allows ref struct
    where TValueEnumerable : IEnumerable<TValue, TValueEnumerator>, allows ref struct
    where TValueEnumerator : IEnumerator<TValue>, allows ref struct
    where TValueKeyMap : IMap<TValue, TKey, TCount, TValueEnumerator>, allows ref struct;

#endregion