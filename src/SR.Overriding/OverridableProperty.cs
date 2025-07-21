using SR.Abstraction;

namespace SR.Overriding;

public sealed class OverridableProperty<T>(T value) : OverridableGetterBase<T>, IProperty<T>
{
    protected override T InternalGet() => value;

    public bool Set(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
