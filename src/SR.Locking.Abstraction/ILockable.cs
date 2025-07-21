namespace SR.Locking.Abstraction;

public interface ILockable
{
    bool IsLocked { get; }

    bool IsLock(object key);

    void Lock(object key);

    void Unlock(object key);
}
