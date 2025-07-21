using SR.Abstraction;

namespace SR.Blocking;

public sealed class BlockableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : BlockablePropertyBase<T>
{
    public override T Get() => getter.Get();

    protected override bool InternalSet(T value) => setter.Set(value);
}
