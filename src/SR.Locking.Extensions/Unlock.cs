using SR.Locking.Abstraction;
using System;

namespace SR.Locking.Extensions;

public readonly struct Unlock : IDisposable
{
    private readonly ILockable m_Lockable;
    private readonly object m_Key;

    internal Unlock(ILockable lockable, object key)
    {
        m_Lockable = lockable;
        m_Key = key;
    }

    public void Dispose() => m_Lockable.Lock(m_Key);
}