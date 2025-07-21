using SR.Abstraction;
using SR.Locking.Abstraction;
using System.Collections.Generic;

namespace SR.Locking;

/// <summary>
/// Base class for lockable setter implementations providing core locking functionality.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public abstract class LockableSetterBase<T> : ISetter<T>, ILockable
{
    private readonly HashSet<object> m_Locks = [];

    /// <inheritdoc/>
    public bool IsLocked => m_Locks.Count > 0;

    /// <inheritdoc/>
    public bool IsLock(object key) => m_Locks.Contains(key);

    /// <inheritdoc/>
    public void Lock(object key) => m_Locks.Add(key);

    /// <inheritdoc/>
    public void Unlock(object key) => m_Locks.Remove(key);

    /// <inheritdoc/>
    public bool Set(T value) => !IsLocked && InternalSet(value);

    /// <summary>
    /// When implemented in derived classes, performs the actual set operation.
    /// </summary>
    /// <param name="value">The value to set.</param>
    /// <returns>True if the value was successfully set; otherwise false.</returns>
    protected abstract bool InternalSet(T value);
}