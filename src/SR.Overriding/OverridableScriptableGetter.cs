using System;

namespace SR.Overriding;

public sealed class OverridableScriptableGetter<T>(Func<T> inner) : OverridableGetterBase<T>
{
    protected override T InternalGet() => inner();
}
