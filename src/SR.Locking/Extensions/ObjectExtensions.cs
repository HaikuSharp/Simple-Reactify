using SR.Abstraction;

namespace SR.Locking.Extensions;

public static class ObjectExtensions
{
    public static LockableProperty<T> AsLockableProperty<T>(this T obj) => new(obj);
}
