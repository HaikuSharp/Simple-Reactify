using SR.Locking.Abstraction;
using System;

namespace SR.Locking.Extensions;

/// <summary>
/// Represents a scope-based lock that automatically releases when disposed.
/// </summary>
public readonly struct Lock : IDisposable
{
    private readonly ILockable m_Lockable;
    private readonly object m_Key;

    internal Lock(ILockable lockable, object key)
    {
        m_Lockable = lockable;
        m_Key = key;
    }

    /// <summary>
    /// Releases the lock by calling <see cref="ILockable.Unlock(object)"/>.
    /// </summary>
    public void Dispose() => m_Lockable.Unlock(m_Key);
}