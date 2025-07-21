using SR.Abstraction;

namespace SR.Locking;

public sealed class LockableProperty<T>(T value) : LockableSetterBase<T>, IProperty<T>
{
    public T Get() => value;

    protected override bool InternalSet(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
