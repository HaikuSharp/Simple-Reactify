using SR.Locking.Abstraction;
using System;

namespace SR.Locking.Extensions;

/// <summary>
/// Represents a scope-based unlock that automatically re-locks when disposed.
/// </summary>
public readonly struct Unlock : IDisposable
{
    private readonly ILockable m_Lockable;
    private readonly object m_Key;

    internal Unlock(ILockable lockable, object key)
    {
        m_Lockable = lockable;
        m_Key = key;
    }

    /// <summary>
    /// Re-applies the lock by calling <see cref="ILockable.Lock(object)"/>.
    /// </summary>
    public void Dispose() => m_Lockable.Lock(m_Key);
}