using SR.Abstraction;
using SR.Locking.Abstraction;
using Sugar.Object.Extensions;
using System.Collections.Generic;

namespace SR.Locking;

public abstract class LockableSetterBase<T> : ISetter<T>, ILockable
{
    private readonly HashSet<object> m_Locks = [];

    public bool IsLocked => m_Locks.Count > 0;

    public bool IsLock(object key) => m_Locks.Contains(key);

    public void Lock(object key) => m_Locks.Add(key).Forget();

    public void Unlock(object key) => m_Locks.Remove(key).Forget();

    public bool Set(T value) => !IsLocked && InternalSet(value);

    protected abstract bool InternalSet(T value);
}