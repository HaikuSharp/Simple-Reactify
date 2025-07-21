using SR.Abstraction;

namespace SR.Locking;

public sealed class LockableWrapSetter<T>(ISetter<T> inner) : LockableSetterBase<T>
{
    protected override bool InternalSet(T value) => inner.Set(value);
}
