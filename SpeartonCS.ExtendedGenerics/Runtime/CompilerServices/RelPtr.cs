using SpeartonCS.ExtendedGenerics.Numerics;

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SpeartonCS.ExtendedGenerics.Runtime.CompilerServices;

public readonly unsafe struct RelPtr<TOffset> :
    IExplicitOperators<RelPtr<TOffset>, TOffset>,

    INullValue<RelPtr<TOffset>>, IZeroValue<RelPtr<TOffset>>,

    IAdditionOperators<RelPtr<TOffset>, TOffset, RelPtr<TOffset>>, ISubtractionOperators<RelPtr<TOffset>, TOffset, RelPtr<TOffset>>

    where TOffset : unmanaged, IBinaryInteger<TOffset>
{
    public RelPtr(TOffset offset) => Offset = offset;
    public readonly TOffset Offset;

    public static RelPtr<TOffset> Null
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(TOffset.Zero);
    }
    public static RelPtr<TOffset> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(TOffset.Zero);
    }

    #region Resolving

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Create(void* relativeTo, out RelPtr<TOffset> ptr)
    {
        Unsafe.SkipInit(out ptr);
        ptr = relativeTo is null ? Null : new(TOffset.CreateChecked((nint)relativeTo - (nint)Unsafe.AsPointer(in ptr)));
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Create<T>(scoped in T relativeTo, out RelPtr<TOffset> ptr) where T : allows ref struct => Create(Unsafe.AsPointer(in relativeTo), out ptr);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CreateFrom(scoped in RelPtr<TOffset> source, out RelPtr<TOffset> ptr) => Create(Resolve(in source), out ptr);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void* Resolve(scoped in RelPtr<TOffset> ptr) => ptr.Offset == TOffset.Zero ? null : (byte*)Unsafe.AsPointer(in ptr) + nint.CreateChecked(ptr.Offset);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* Resolve<T>(scoped in RelPtr<TOffset> ptr) where T : allows ref struct
        => ptr.Offset == TOffset.Zero ? null : (T*)((byte*)Unsafe.AsPointer(in ptr) + nint.CreateChecked(ptr.Offset));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AreSame(scoped in RelPtr<TOffset> a, scoped in RelPtr<TOffset> b) => Unsafe.AreSame(in a, in b);

    #endregion

    #region Math

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RelPtr<TOffset> operator +(RelPtr<TOffset> left, TOffset right) => new(left.Offset + right);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RelPtr<TOffset> operator -(RelPtr<TOffset> left, TOffset right) => new(left.Offset - right);

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator RelPtr<TOffset>(TOffset other) => new(other);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator TOffset(RelPtr<TOffset> other) => other.Offset;

    #endregion
}

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct RelPtr<T, TOffset> :
    IExplicitOperators<RelPtr<T, TOffset>, TOffset>,
    IExplicitOperators<RelPtr<T, TOffset>, RelPtr<TOffset>>,

    INullValue<RelPtr<T, TOffset>>, IZeroValue<RelPtr<T, TOffset>>,

    IAdditionOperators<RelPtr<T, TOffset>, TOffset, RelPtr<T, TOffset>>,
    ISubtractionOperators<RelPtr<T, TOffset>, TOffset, RelPtr<T, TOffset>>

    where T : allows ref struct
    where TOffset : unmanaged, IBinaryInteger<TOffset>
{
    public RelPtr(TOffset offset) => Offset = offset;
    public readonly TOffset Offset;

    public static RelPtr<T, TOffset> Null
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(TOffset.Zero);
    }

    public static RelPtr<T, TOffset> Zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(TOffset.Zero);
    }

    #region Resolving

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Create(void* relativeTo, out RelPtr<T, TOffset> ptr)
    {
        Unsafe.SkipInit(out ptr);
        ptr = relativeTo is null ? Null : new(TOffset.CreateChecked((nint)relativeTo - (nint)Unsafe.AsPointer(in ptr)));
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Create(scoped in T relativeTo, out RelPtr<T, TOffset> ptr) => Create(Unsafe.AsPointer(in relativeTo), out ptr);
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CreateFrom(scoped in RelPtr<T, TOffset> source, out RelPtr<T, TOffset> ptr) => Create(Resolve(in source), out ptr);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CreateFrom(scoped in RelPtr<TOffset> source, out RelPtr<T, TOffset> ptr) => Create(RelPtr<TOffset>.Resolve(in source), out ptr);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* Resolve(scoped in RelPtr<T, TOffset> ptr)
        => ptr.Offset == TOffset.Zero ? null : (T*)((byte*)Unsafe.AsPointer(in ptr) + nint.CreateChecked(ptr.Offset));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AreSame(scoped in RelPtr<T, TOffset> a, scoped in RelPtr<T, TOffset> b)
        => Unsafe.AreSame(in a, in b);

    #endregion

    #region Math

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RelPtr<T, TOffset> operator +(RelPtr<T, TOffset> left, TOffset right) => new(left.Offset + right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RelPtr<T, TOffset> operator -(RelPtr<T, TOffset> left, TOffset right) => new(left.Offset - right);

    #endregion

    #region Casts

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator RelPtr<T, TOffset>(TOffset other) => new(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator TOffset(RelPtr<T, TOffset> other) => other.Offset;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator RelPtr<T, TOffset>(RelPtr<TOffset> other) => new(other.Offset);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator RelPtr<TOffset>(RelPtr<T, TOffset> other) => new(other.Offset);

    #endregion
}