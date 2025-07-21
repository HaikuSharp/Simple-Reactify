using SR.Abstraction;

namespace SR.Overriding;

public sealed class OverridableWrapGetter<T>(IGetter<T> inner) : OverridableGetterBase<T>
{
    protected override T InternalGet() => inner.Get();
}
