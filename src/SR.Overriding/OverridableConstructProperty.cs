using SR.Abstraction;

namespace SR.Overriding;

public sealed class OverridableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : OverridableGetterBase<T>, IProperty<T>
{
    protected override T InternalGet() => getter.Get();

    public bool Set(T value) => setter.Set(value);
}
