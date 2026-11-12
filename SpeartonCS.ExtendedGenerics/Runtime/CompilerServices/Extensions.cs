using System.Runtime.CompilerServices;

namespace SpeartonCS.ExtendedGenerics.Runtime.CompilerServices;

public static unsafe class PtrExtensions
{
    extension<T>(Ptr<T>)
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Ref<T> AsRef(Ptr<T> ptr) => new(ref *ptr.Value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefReadOnly<T> AsRefReadonly(Ptr<T> ptr) => new(ref *ptr.Value);
    }
}