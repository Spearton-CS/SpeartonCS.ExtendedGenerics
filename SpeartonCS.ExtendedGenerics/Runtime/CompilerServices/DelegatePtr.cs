using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

using SpeartonCS.ExtendedGenerics.Numerics;

namespace SpeartonCS.ExtendedGenerics.Runtime.CompilerServices;

#region 0

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr :
    IEquatable<ManagedActionPtr>, IEqualityOperators<ManagedActionPtr, ManagedActionPtr, bool>, ITrueFalseOperators<ManagedActionPtr>,

    IZeroValue<ManagedActionPtr>,

    IExplicitOperators<ManagedActionPtr, nuint>, IExplicitOperators<ManagedActionPtr, nint>,
    IExplicitOperators<ManagedActionPtr, ulong>, IExplicitOperators<ManagedActionPtr, long>,
    IExplicitOperators<ManagedActionPtr, uint>, IExplicitOperators<ManagedActionPtr, int>
{
    public ManagedActionPtr(delegate* managed<void> value) => Value = value;
    public readonly delegate* managed<void> Value;

    public static ManagedActionPtr Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr left, ManagedActionPtr right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr left, ManagedActionPtr right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr(delegate* managed<void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<void>(ManagedActionPtr ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(void* value) => new((delegate* managed<void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(nuint value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(nint value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(ulong value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(long value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(uint value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(int value) => (delegate* managed<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr :
    IEquatable<UnmanagedActionPtr>, IEqualityOperators<UnmanagedActionPtr, UnmanagedActionPtr, bool>, ITrueFalseOperators<UnmanagedActionPtr>,

    IZeroValue<UnmanagedActionPtr>,

    IExplicitOperators<UnmanagedActionPtr, ManagedActionPtr>,
    IExplicitOperators<UnmanagedActionPtr, nuint>, IExplicitOperators<UnmanagedActionPtr, nint>,
    IExplicitOperators<UnmanagedActionPtr, ulong>, IExplicitOperators<UnmanagedActionPtr, long>,
    IExplicitOperators<UnmanagedActionPtr, uint>, IExplicitOperators<UnmanagedActionPtr, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<void> value) => Value = value;
    public readonly delegate* unmanaged<void> Value;

    public static UnmanagedActionPtr Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr left, UnmanagedActionPtr right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr left, UnmanagedActionPtr right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr(delegate* unmanaged<void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<void>(UnmanagedActionPtr ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(void* value) => new((delegate* unmanaged<void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(ManagedActionPtr man) => new((delegate* unmanaged<void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr(UnmanagedActionPtr unman) => new((delegate* managed<void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(nuint value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(nint value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(ulong value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(long value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(uint value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr(int value) => (delegate* unmanaged<void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 1

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1> :
    IEquatable<ManagedActionPtr<T1>>, IEqualityOperators<ManagedActionPtr<T1>, ManagedActionPtr<T1>, bool>, ITrueFalseOperators<ManagedActionPtr<T1>>,

    IZeroValue<ManagedActionPtr<T1>>,

    IExplicitOperators<ManagedActionPtr<T1>, nuint>, IExplicitOperators<ManagedActionPtr<T1>, nint>,
    IExplicitOperators<ManagedActionPtr<T1>, ulong>, IExplicitOperators<ManagedActionPtr<T1>, long>,
    IExplicitOperators<ManagedActionPtr<T1>, uint>, IExplicitOperators<ManagedActionPtr<T1>, int>
{
    public ManagedActionPtr(delegate* managed<T1, void> value) => Value = value;
    public readonly delegate* managed<T1, void> Value;

    public static ManagedActionPtr<T1> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1> left, ManagedActionPtr<T1> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1> left, ManagedActionPtr<T1> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1>(delegate* managed<T1, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, void>(ManagedActionPtr<T1> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(void* value) => new((delegate* managed<T1, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(nuint value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(nint value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(ulong value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(long value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(uint value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(int value) => (delegate* managed<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1> :
    IEquatable<UnmanagedActionPtr<T1>>, IEqualityOperators<UnmanagedActionPtr<T1>, UnmanagedActionPtr<T1>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1>>,

    IZeroValue<UnmanagedActionPtr<T1>>,

    IExplicitOperators<UnmanagedActionPtr<T1>, ManagedActionPtr<T1>>,
    IExplicitOperators<UnmanagedActionPtr<T1>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1>, uint>, IExplicitOperators<UnmanagedActionPtr<T1>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, void> Value;

    public static UnmanagedActionPtr<T1> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1> left, UnmanagedActionPtr<T1> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1> left, UnmanagedActionPtr<T1> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1>(delegate* unmanaged<T1, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, void>(UnmanagedActionPtr<T1> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(void* value) => new((delegate* unmanaged<T1, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(ManagedActionPtr<T1> man) => new((delegate* unmanaged<T1, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1>(UnmanagedActionPtr<T1> unman) => new((delegate* managed<T1, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(nuint value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(nint value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(ulong value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(long value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(uint value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1>(int value) => (delegate* unmanaged<T1, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 2

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2> :
    IEquatable<ManagedActionPtr<T1, T2>>, IEqualityOperators<ManagedActionPtr<T1, T2>, ManagedActionPtr<T1, T2>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2>>,

    IZeroValue<ManagedActionPtr<T1, T2>>,

    IExplicitOperators<ManagedActionPtr<T1, T2>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, void> Value;

    public static ManagedActionPtr<T1, T2> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2> left, ManagedActionPtr<T1, T2> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2> left, ManagedActionPtr<T1, T2> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2>(delegate* managed<T1, T1, T2, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, void>(ManagedActionPtr<T1, T2> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(void* value) => new((delegate* managed<T1, T1, T2, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(nuint value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(nint value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(ulong value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(long value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(uint value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(int value) => (delegate* managed<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2> :
    IEquatable<UnmanagedActionPtr<T1, T2>>, IEqualityOperators<UnmanagedActionPtr<T1, T2>, UnmanagedActionPtr<T1, T2>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2>>,

    IZeroValue<UnmanagedActionPtr<T1, T2>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2>, ManagedActionPtr<T1, T2>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, void> Value;

    public static UnmanagedActionPtr<T1, T2> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2> left, UnmanagedActionPtr<T1, T2> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2> left, UnmanagedActionPtr<T1, T2> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2>(delegate* unmanaged<T1, T1, T2, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, void>(UnmanagedActionPtr<T1, T2> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(void* value) => new((delegate* unmanaged<T1, T1, T2, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(ManagedActionPtr<T1, T2> man) => new((delegate* unmanaged<T1, T1, T2, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2>(UnmanagedActionPtr<T1, T2> unman) => new((delegate* managed<T1, T1, T2, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(nuint value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(nint value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(ulong value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(long value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(uint value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2>(int value) => (delegate* unmanaged<T1, T1, T2, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 3

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3> :
    IEquatable<ManagedActionPtr<T1, T2, T3>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3>, ManagedActionPtr<T1, T2, T3>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, void> Value;

    public static ManagedActionPtr<T1, T2, T3> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3> left, ManagedActionPtr<T1, T2, T3> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3> left, ManagedActionPtr<T1, T2, T3> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3>(delegate* managed<T1, T1, T2, T1, T2, T3, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, void>(ManagedActionPtr<T1, T2, T3> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3>, UnmanagedActionPtr<T1, T2, T3>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, ManagedActionPtr<T1, T2, T3>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3> left, UnmanagedActionPtr<T1, T2, T3> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3> left, UnmanagedActionPtr<T1, T2, T3> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>(UnmanagedActionPtr<T1, T2, T3> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(ManagedActionPtr<T1, T2, T3> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3>(UnmanagedActionPtr<T1, T2, T3> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 4

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4>, ManagedActionPtr<T1, T2, T3, T4>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4> left, ManagedActionPtr<T1, T2, T3, T4> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4> left, ManagedActionPtr<T1, T2, T3, T4> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>(ManagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4>, UnmanagedActionPtr<T1, T2, T3, T4>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, ManagedActionPtr<T1, T2, T3, T4>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4> left, UnmanagedActionPtr<T1, T2, T3, T4> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4> left, UnmanagedActionPtr<T1, T2, T3, T4> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(ManagedActionPtr<T1, T2, T3, T4> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4>(UnmanagedActionPtr<T1, T2, T3, T4> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 5

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, ManagedActionPtr<T1, T2, T3, T4, T5>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5> left, ManagedActionPtr<T1, T2, T3, T4, T5> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5> left, ManagedActionPtr<T1, T2, T3, T4, T5> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, UnmanagedActionPtr<T1, T2, T3, T4, T5>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, ManagedActionPtr<T1, T2, T3, T4, T5>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5> left, UnmanagedActionPtr<T1, T2, T3, T4, T5> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5> left, UnmanagedActionPtr<T1, T2, T3, T4, T5> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(ManagedActionPtr<T1, T2, T3, T4, T5> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5>(UnmanagedActionPtr<T1, T2, T3, T4, T5> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 6

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, ManagedActionPtr<T1, T2, T3, T4, T5, T6>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, ManagedActionPtr<T1, T2, T3, T4, T5, T6>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(ManagedActionPtr<T1, T2, T3, T4, T5, T6> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 7

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 8

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 9

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 10

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 11

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 12

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 13

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 14

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion

#region 15

#region ActionPtr

[DebuggerDisplay("{Value}")]
public readonly unsafe struct ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> :
    IEquatable<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IEqualityOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, bool>, ITrueFalseOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>,

    IZeroValue<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>,

    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, nuint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, nint>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, ulong>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, long>,
    IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, uint>, IExplicitOperators<ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, int>
{
    public ManagedActionPtr(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> value) => Value = value;
    public readonly delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> Value;

    public static ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(void* value) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(nuint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(nint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ulong value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(long value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(uint value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int value) => (delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (int)ptr.Value;

    #endregion
}

[DebuggerDisplay("{Value}")]
public readonly unsafe struct UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> :
    IEquatable<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IEqualityOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, bool>, ITrueFalseOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>,

    IZeroValue<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>,

    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, nuint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, nint>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, ulong>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, long>,
    IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, uint>, IExplicitOperators<UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, int>
{
    public UnmanagedActionPtr(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> value) => Value = value;
    public readonly delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> Value;

    public static UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(null);
    }

    #region Equality

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override bool Equals([NotNullWhen(true)] object? obj) => obj is UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other && this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other) => this == other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override int GetHashCode() => ((nuint)Value).GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => left.Value == right.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => left.Value != right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator true(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value is not null;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator false(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value is null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly override string ToString() => ((nuint)Value).ToString();

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> value) => new(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(void* value) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator void*(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> man) => new((delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)man.Value);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ManagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> unman) => new((delegate* managed<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)unman.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(nuint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nuint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (nuint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(nint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator nint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (nint)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ulong value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (ulong)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(long value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (long)ptr.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(uint value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (uint)ptr.Value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int value) => (delegate* unmanaged<T1, T1, T2, T1, T2, T3, T1, T2, T3, T4, T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, T9, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)value;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(UnmanagedActionPtr<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ptr) => (int)ptr.Value;

    #endregion
}

#endregion

#region FuncPtr



#endregion

#endregion
