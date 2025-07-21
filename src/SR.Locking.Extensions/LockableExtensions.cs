using SR.Locking.Abstraction;

namespace SR.Locking.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ILockable"/> to enable scope-based locking.
/// </summary>
public static class LockableExtensions
{
    /// <summary>
    /// Locks the object and returns a <see cref="Lock"/> that will automatically unlock when disposed.
    /// </summary>
    /// <param name="lockable">The lockable object.</param>
    /// <param name="key">The key to use for locking.</param>
    /// <returns>A <see cref="Lock"/> instance that will unlock on disposal.</returns>
    public static Lock LockWithScope(this ILockable lockable, object key)
    {
        lockable.Lock(key);
        return new(lockable, key);
    }

    /// <summary>
    /// Unlocks the object and returns an <see cref="Unlock"/> that will automatically relock when disposed.
    /// </summary>
    /// <param name="lockable">The lockable object.</param>
    /// <param name="key">The key to use for unlocking.</param>
    /// <returns>An <see cref="Unlock"/> instance that will relock on disposal.</returns>
    public static Unlock UnlockWithScope(this ILockable lockable, object key)
    {
        lockable.Unlock(key);
        return new(lockable, key);
    }
}