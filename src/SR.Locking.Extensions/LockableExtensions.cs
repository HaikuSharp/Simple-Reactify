using SR.Locking.Abstraction;

namespace SR.Locking.Extensions;

public static class LockableExtensions
{
    public static Lock LockWithScope(this ILockable lockable, object key)
    {
        lockable.Lock(key);
        return new(lockable, key);
    }

    public static Unlock UnlockWithScope(this ILockable lockable, object key)
    {
        lockable.Unlock(key);
        return new(lockable, key);
    }
}
