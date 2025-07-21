using SR.Abstraction;

namespace SR.Locking;

public sealed class LockableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : LockableSetterBase<T>, IProperty<T>
{
    public T Get() => getter.Get();

    protected override bool InternalSet(T value) => setter.Set(value);
}
