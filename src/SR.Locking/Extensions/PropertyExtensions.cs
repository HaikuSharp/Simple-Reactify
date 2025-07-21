using SR.Abstraction;

namespace SR.Locking.Extensions;

public static class PropertyExtensions
{
    public static LockableWrapProperty<T> AsLockable<T>(this IProperty<T> obj) => new(obj);
}
