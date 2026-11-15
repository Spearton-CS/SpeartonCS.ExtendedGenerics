# SpeartonCS API Reference

## SpeartonCS.ExtendedGenerics

| Kind | Type |
| :--- | :--- |
| `interface` | `ICloneable<TSelf>` |
| `interface` | **`IFactory`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IFactory<TResult>`<br>&nbsp;&nbsp;↳ `[interface] IFactory<TResult, T1..T15>` |
| `interface` | `INullValue<TSelf>` |

## SpeartonCS.ExtendedGenerics.Collections

| Kind | Type |
| :--- | :--- |
| `interface` | `IAsyncEnumerable<T, TEnumerator>` |
| `interface` | **`IAsyncReadOnlyRefEnumerable`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncReadOnlyRefEnumerable<T>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncReadOnlyRefEnumerable<T, TEnumerator>` |
| `interface` | `IAsyncReadOnlyRefEnumerator<T>` |
| `interface` | **`IAsyncRefEnumerable`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncRefEnumerable<T>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncRefEnumerable<T, TEnumerator>` |
| `interface` | `IAsyncRefEnumerator<T>` |
| `interface` | `IClearable` |
| `interface` | **`ICollection`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] ICollection<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] ICollection<TElement, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] ICollection<TElement, TCount, TEnumerator, TIndex>` |
| `interface` | **`ICopyable`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] ICopyable<TDestination>`<br>&nbsp;&nbsp;↳ `[interface] ICopyable<TDestination, TIndex>` |
| `interface` | **`IDeque`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IDeque<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IDeque<TElement, TCount, TEnumerator>` |
| `interface` | **`IDictionary`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IDictionary<TKey, TValue, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IDictionary<TKey, TValue, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>` |
| `interface` | `IEmptyValue<TSelf>` |
| `interface` | `IEnumerable<T, TEnumerator>` |
| `interface` | `IIndexable<TIndex, TResult>` |
| `interface` | **`ILinkedList`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] ILinkedList<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] ILinkedList<TElement, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] ILinkedList<TElement, TCount, TEnumerator, TNode>` |
| `interface` | **`ILinkedNode`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] ILinkedNode<TElement>`<br>&nbsp;&nbsp;↳ `[interface] ILinkedNode<TSelf, TElement>` |
| `interface` | `IList<TElement, TCount, TEnumerator, TIndex>` |
| `interface` | **`IMap`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IMap<TKey, TValue, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IMap<TKey, TValue, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator, TValueKeyMap>` |
| `interface` | **`IPriorityQueue`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IPriorityQueue<TElement, TPriority, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IPriorityQueue<TElement, TPriority, TCount, TEnumerator>` |
| `interface` | **`IQueue`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IQueue<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IQueue<TElement, TCount, TEnumerator>` |
| `interface` | **`IRange`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IRange<TSelf, TScalar>`<br>&nbsp;&nbsp;↳ `[interface] IRange<TSelf, TScalar, TLength>` |
| `interface` | **`IReadOnlyCollection`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyCollection<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyCollection<TElement, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyCollection<TElement, TCount, TEnumerator, TIndex>` |
| `interface` | **`IReadOnlyDeque`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyDeque<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyDeque<TElement, TCount, TEnumerator>` |
| `interface` | **`IReadOnlyDictionary`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyDictionary<TKey, TValue, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyDictionary<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>` |
| `interface` | `IReadOnlyIndexable<TIndex, TResult>` |
| `interface` | **`IReadOnlyLinkedList`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyLinkedList<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyLinkedList<TElement, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyLinkedList<TElement, TCount, TEnumerator, TNode>` |
| `interface` | **`IReadOnlyLinkedNode`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyLinkedNode<TElement>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyLinkedNode<TSelf, TElement>` |
| `interface` | `IReadOnlyList<TElement, TCount, TEnumerator, TIndex>` |
| `interface` | **`IReadOnlyMap`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyMap<TKey, TValue, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyMap<TKey, TValue, TCount, TEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyMap<TKey, TValue, TCount, TEnumerator, TValueEnumerable, TValueEnumerator, TValueKeyMap>` |
| `interface` | **`IReadOnlyPriorityQueue`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyPriorityQueue<TElement, TPriority, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyPriorityQueue<TElement, TPriority, TCount, TEnumerator>` |
| `interface` | **`IReadOnlyQueue`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyQueue<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyQueue<TElement, TCount, TEnumerator>` |
| `interface` | **`IReadOnlyRefEnumerable`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyRefEnumerable<T>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyRefEnumerable<T, TEnumerator>` |
| `interface` | `IReadOnlyRefEnumerator<T>` |
| `interface` | `IReadOnlyRefIndexable<TIndex, TResult>` |
| `interface` | **`IReadOnlySet`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlySet<TKey, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlySet<TKey, TCount, TEnumerator>` |
| `interface` | **`IReadOnlyStack`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyStack<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IReadOnlyStack<TElement, TCount, TEnumerator>` |
| `interface` | **`IRefEnumerable`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IRefEnumerable<T>`<br>&nbsp;&nbsp;↳ `[interface] IRefEnumerable<T, TEnumerator>` |
| `interface` | `IRefEnumerator<T>` |
| `interface` | `IRefIndexable<TIndex, TResult>` |
| `interface` | `IResetable` |
| `interface` | **`ISet`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] ISet<TKey, TCount>`<br>&nbsp;&nbsp;↳ `[interface] ISet<TKey, TCount, TEnumerator>` |
| `interface` | `ISliceable<TSlice, TIndex, TLength>` |
| `interface` | **`IStack`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IStack<TElement, TCount>`<br>&nbsp;&nbsp;↳ `[interface] IStack<TElement, TCount, TEnumerator>` |

## SpeartonCS.ExtendedGenerics.DuckTyping

| Kind | Type |
| :--- | :--- |
| `interface` | `IAsyncIteratorMethodBuilder<TBuilder>` |
| `interface` | **`IAsyncMethodBuilder`** `<..>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncMethodBuilder<TBuilder, TTask>`<br>&nbsp;&nbsp;↳ `[interface] IAsyncMethodBuilder<TBuilder, TTask, TResult>` |
| `interface` | **`IAwaitable`**<br>&nbsp;&nbsp;↳ `[interface] IAwaitable`<br>&nbsp;&nbsp;↳ `[interface] IAwaitable<TAwaiter>`<br>&nbsp;&nbsp;↳ `[interface] IAwaitable<TAwaiter, TResult>` |
| `interface` | **`IAwaiter`**<br>&nbsp;&nbsp;↳ `[interface] IAwaiter`<br>&nbsp;&nbsp;↳ `[interface] IAwaiter<TResult>` |
| `interface` | `ICollectionBuilder<TCollection, TElement>` |
| `interface` | `IDeconstructible<T1..T15>` |
| `interface` | `IInterpolatedStringHandler` |
| `interface` | `IInterpolatedStringLiteralHandler` |
| `interface` | `IInterpolatedStringSpanHandler` |
| `interface` | **`IInterpolatedStringTHandler`**<br>&nbsp;&nbsp;↳ `[interface] IInterpolatedStringTHandler`<br>&nbsp;&nbsp;↳ `[interface] IInterpolatedStringTHandler<T>` |
| `interface` | `IPinnable<TPinnedReference>` |

## SpeartonCS.ExtendedGenerics.Numerics

| Kind | Type |
| :--- | :--- |
| `interface` | `IAllBitsSetValue<TSelf>` |
| `interface` | `IBitwiseAndOperators<TSelf, TOther, TResult>` |
| `interface` | `IBitwiseNotOperators<TSelf, TResult>` |
| `interface` | `IBitwiseOrOperators<TSelf, TOther, TResult>` |
| `interface` | `IBitwiseXorOperators<TSelf, TOther, TResult>` |
| `interface` | `IConditionalLogicalOperators<TSelf>` |
| `interface` | `IExplicitFromOperators<TSelf, TOther>` |
| `interface` | `IExplicitOperators<TSelf, TOther>` |
| `interface` | `IExplicitToOperators<TSelf, TOther>` |
| `interface` | `IImplicitFromOperators<TSelf, TOther>` |
| `interface` | `IImplicitOperators<TSelf, TOther>` |
| `interface` | `IImplicitToOperators<TSelf, TOther>` |
| `interface` | `ILeftShiftOperators<TSelf, TShift, TResult>` |
| `interface` | `ILogicalNotOperators<TSelf, TResult>` |
| `interface` | `IMaxValue<TSelf>` |
| `interface` | `IMinValue<TSelf>` |
| `interface` | `INegativeOneValue<TSelf>` |
| `interface` | `IOneValue<TSelf>` |
| `interface` | `IRightShiftOperators<TSelf, TShift, TResult>` |
| `interface` | `ITrueFalseOperators<TSelf>` |
| `interface` | `IURightShiftOperators<TSelf, TShift, TResult>` |
| `interface` | `IZeroValue<TSelf>` |

## SpeartonCS.ExtendedGenerics.Runtime.CompilerServices

| Kind | Type |
| :--- | :--- |
| `readonly struct` | **`ManagedActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] ManagedActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] ManagedActionPtr<T1..T15>` |
| `readonly struct` | **`ManagedFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] ManagedFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] ManagedFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`Ptr`**<br>&nbsp;&nbsp;↳ `[readonly struct] Ptr`<br>&nbsp;&nbsp;↳ `[readonly struct] Ptr<T>` |
| `static class` | `PtrExtensions` |
| `readonly ref struct` | `Ref<T>` |
| `readonly ref struct` | `RefReadOnly<T>` |
| `readonly struct` | **`RelPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] RelPtr<TOffset>`<br>&nbsp;&nbsp;↳ `[readonly struct] RelPtr<T, TOffset>` |
| `readonly struct` | **`UnmanagedActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedCdeclActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedCdeclFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedCdeclSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedCdeclSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedCdeclSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedFastcallActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedFastcallFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedFastcallSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedFastcallSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFastcallSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedMemberFunctionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedMemberFunctionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedMemberFunctionSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedMemberFunctionSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedMemberFunctionSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedStdcallActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedStdcallFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedStdcallSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedStdcallSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedStdcallSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedSwiftActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedSwiftFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedSwiftSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedSwiftSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedSwiftSuppressGCTransitionFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedThiscallActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedThiscallFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallFuncPtr<T1..T15, TResult>` |
| `readonly struct` | **`UnmanagedThiscallSuppressGCTransitionActionPtr`**<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallSuppressGCTransitionActionPtr`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallSuppressGCTransitionActionPtr<T1..T15>` |
| `readonly struct` | **`UnmanagedThiscallSuppressGCTransitionFuncPtr`** `<..>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallSuppressGCTransitionFuncPtr<TResult>`<br>&nbsp;&nbsp;↳ `[readonly struct] UnmanagedThiscallSuppressGCTransitionFuncPtr<T1..T15, TResult>` |

