using SpeartonCS.ExtendedGenerics.Collections;
using SpeartonCS.ExtendedGenerics.Numerics;

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.Runtime.CompilerServices;

[DebuggerDisplay("{Value}")]
public readonly unsafe struct Ptr :
    IEquatable<Ptr>, IEqualityOperators<Ptr, Ptr, bool>, ITrueFalseOperators<Ptr>,

    IZeroValue<Ptr>,

    IRefIndexable<nuint, byte>, IRefIndexable<nint, byte>,
    IRefIndexable<ulong, byte>, IRefIndexable<long, byte>,
    IRefIndexable<uint, byte>, IRefIndexable<int, byte>,

    IImplicitToOperators<Ptr, RefReadOnly<byte>>, IImplicitToOperators<Ptr, Ref<byte>>,

    IExplicitOperators<Ptr, nuint>, IExplicitOperators<Ptr, nint>,
    IExplicitOperators<Ptr, ulong>, IExplicitOperators<Ptr, long>,
    IExplicitOperators<Ptr, uint>, IExplicitOperators<Ptr, int>,

    IAdditionOperators<Ptr, nuint, Ptr>, ISubtractionOperators<Ptr, nint, Ptr>,
    IAdditionOperators<Ptr, ulong, Ptr>, ISubtractionOperators<Ptr, long, Ptr>,
    IAdditionOperators<Ptr, uint, Ptr>, ISubtractionOperators<Ptr, int, Ptr>
{
    public Ptr(void* value) => Value = value;
    public readonly void* Value;

    public static Ptr Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is Ptr other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(Ptr other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Ptr left, Ptr right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Ptr left, Ptr right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(Ptr ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(Ptr ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Math

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, nuint offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, nuint offset) => (byte*)ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, nint offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, nint offset) => (byte*)ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, ulong offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, ulong offset) => (byte*)ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, long offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, long offset) => (byte*)ptr.Value - offset;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, uint offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, uint offset) => (byte*)ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator +(Ptr ptr, int offset) => (byte*)ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr operator -(Ptr ptr, int offset) => (byte*)ptr.Value - offset;

    #endregion

    #region Indexability

    public ref byte this[nuint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }
    public ref byte this[nint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }

    public ref byte this[ulong index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }
    public ref byte this[long index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }

    public ref byte this[uint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }
    public ref byte this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *((byte*)Value + index);
    }

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Ptr(void* value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(Ptr ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Ref<byte>(Ptr ptr) => new(ref *(byte*)ptr.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefReadOnly<byte>(Ptr ptr) => new(ref *(byte*)ptr.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(nuint value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(Ptr ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(nint value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(Ptr ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(ulong value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(Ptr ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(long value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(Ptr ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(uint value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(Ptr ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr(int value) => (void*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(Ptr ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct Ptr<T> :
    IEquatable<Ptr<T>>, IEqualityOperators<Ptr<T>, Ptr<T>, bool>, ITrueFalseOperators<Ptr<T>>,

    IZeroValue<Ptr<T>>,

    IRefIndexable<nuint, T>, IRefIndexable<nint, T>,
    IRefIndexable<ulong, T>, IRefIndexable<long, T>,
    IRefIndexable<uint, T>, IRefIndexable<int, T>,

    IImplicitToOperators<Ptr<T>, RefReadOnly<byte>>, IImplicitToOperators<Ptr<T>, Ref<byte>>,

    IImplicitToOperators<Ptr<T>, Ptr>, IExplicitFromOperators<Ptr<T>, Ptr>,
    IExplicitOperators<Ptr<T>, nuint>, IExplicitOperators<Ptr<T>, nint>,
    IExplicitOperators<Ptr<T>, ulong>, IExplicitOperators<Ptr<T>, long>,
    IExplicitOperators<Ptr<T>, uint>, IExplicitOperators<Ptr<T>, int>,

    IAdditionOperators<Ptr<T>, nuint, Ptr<T>>, ISubtractionOperators<Ptr<T>, nint, Ptr<T>>,
    IAdditionOperators<Ptr<T>, ulong, Ptr<T>>, ISubtractionOperators<Ptr<T>, long, Ptr<T>>,
    IAdditionOperators<Ptr<T>, uint, Ptr<T>>, ISubtractionOperators<Ptr<T>, int, Ptr<T>>

    where T : allows ref struct
{
    public Ptr(T* value) => Value = value;
    public readonly T* Value;

    public static Ptr<T> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is Ptr<T> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(Ptr<T> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Ptr<T> left, Ptr<T> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Ptr<T> left, Ptr<T> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(Ptr<T> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(Ptr<T> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Math

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(nuint offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, nuint offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, nuint offset) => ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(nint offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, nint offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, nint offset) => ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(ulong offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, ulong offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, ulong offset) => ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(long offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, long offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, long offset) => ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(uint offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, uint offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, uint offset) => ptr.Value - offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Ptr<T> AddByteOffset(int offset) => (T*)((byte*)Value + offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator +(Ptr<T> ptr, int offset) => ptr.Value + offset;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> operator -(Ptr<T> ptr, int offset) => ptr.Value - offset;

    #endregion

    #region Indexability

    public ref T this[nuint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }
    public ref T this[nint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }

    public ref T this[ulong index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }
    public ref T this[long index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }

    public ref T this[uint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }
    public ref T this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref *(Value + index);
    }

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Ptr<T>(T* value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator T*(Ptr<T> ptr) => ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(void* value) => new((T*)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(Ptr<T> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Ref<byte>(Ptr<T> ptr) => new(ref *(byte*)ptr.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefReadOnly<byte>(Ptr<T> ptr) => new(ref *(byte*)ptr.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(Ptr value) => new((T*)value.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Ptr(Ptr<T> ptr) => new(ptr.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(nuint value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(Ptr<T> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(nint value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(Ptr<T> ptr) => (nint)ptr.Value;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(ulong value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(Ptr<T> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(long value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(Ptr<T> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(uint value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(Ptr<T> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Ptr<T>(int value) => (T*)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(Ptr<T> ptr) => (int)ptr.Value;

    #endregion
}