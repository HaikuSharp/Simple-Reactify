namespace SR.Locking.Abstraction;

/// <summary>
/// Represents an object that can be locked and unlocked using key-based synchronization.
/// </summary>
public interface ILockable
{
    /// <summary>
    /// Gets a value indicating whether the object is currently locked.
    /// </summary>
    /// <value>
    /// <c>true</c> if the object has any active locks; otherwise, <c>false</c>.
    /// </value>
    bool IsLocked { get; }

    /// <summary>
    /// Determines whether a specific key is currently locking the object.
    /// </summary>
    /// <param name="key">The lock key to check.</param>
    /// <returns>
    /// <c>true</c> if the specified key is currently locking the object; otherwise, <c>false</c>.
    /// </returns>
    bool IsLock(object key);

    /// <summary>
    /// Locks the object using the specified key.
    /// </summary>
    /// <param name="key">The key to use for locking.</param>
    void Lock(object key);

    /// <summary>
    /// Unlocks the object using the specified key.
    /// </summary>
    /// <param name="key">The key that was used to lock the object.</param>
    void Unlock(object key);
}