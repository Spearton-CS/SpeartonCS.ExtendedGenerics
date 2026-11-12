using SpeartonCS.ExtendedGenerics.Numerics;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.Runtime.CompilerServices;

public readonly ref struct RefReadOnly<T> :
    IEquatable<RefReadOnly<T>>, ITrueFalseOperators<RefReadOnly<T>>,
    IImplicitToOperators<RefReadOnly<T>, T>
{
    public RefReadOnly(ref readonly T value) => Value = ref value;
    public readonly ref readonly T Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(RefReadOnly<T> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(RefReadOnly<T> self) => !Unsafe.IsNullRef(in self.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(RefReadOnly<T> self) => Unsafe.IsNullRef(in self.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(RefReadOnly<T> a, RefReadOnly<T> b) => Unsafe.AreSame(in a.Value, in b.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(RefReadOnly<T> a, RefReadOnly<T> b) => !Unsafe.AreSame(in a.Value, in b.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator T(RefReadOnly<T> self) => self.Value;
}

public readonly ref struct Ref<T> :
    IEquatable<Ref<T>>, ITrueFalseOperators<Ref<T>>,
    IImplicitToOperators<Ref<T>, T>, IImplicitToOperators<Ref<T>, RefReadOnly<T>>
{
    public Ref(ref T value) => Value = ref value;
    public readonly ref T Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => false;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(Ref<T> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(Ref<T> self) => !Unsafe.IsNullRef(in self.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(Ref<T> self) => Unsafe.IsNullRef(in self.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Ref<T> a, Ref<T> b) => Unsafe.AreSame(in a.Value, in b.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Ref<T> a, Ref<T> b) => !Unsafe.AreSame(in a.Value, in b.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefReadOnly<T>(Ref<T> self) => new(ref self.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator T(Ref<T> self) => self.Value;
}