using SR.Abstraction;

namespace SR.Overriding;

public sealed class OverridableWrapProperty<T>(IProperty<T> inner) : OverridableGetterBase<T>, IProperty<T>
{
    protected override T InternalGet() => inner.Get();

    public bool Set(T value) => inner.Set(value);
}
