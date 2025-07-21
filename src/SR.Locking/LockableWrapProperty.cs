using SR.Abstraction;

namespace SR.Locking;

public sealed class LockableWrapProperty<T>(IProperty<T> inner) : LockableSetterBase<T>, IProperty<T>
{
    public T Get() => inner.Get();

    protected override bool InternalSet(T value) => inner.Set(value);
}
