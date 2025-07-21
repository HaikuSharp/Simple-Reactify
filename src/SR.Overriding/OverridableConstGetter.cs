namespace SR.Overriding;

public sealed class OverridableConstGetter<T>(T value) : OverridableGetterBase<T>
{
    protected override T InternalGet() => value;
}
