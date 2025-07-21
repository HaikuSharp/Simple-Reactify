using SR.Abstraction;

namespace SR.Overriding;

/// <summary>
/// An overridable property implementation that delegates to separate getter and setter instances.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class OverridableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : OverridableGetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => getter.Get();

    /// <inheritdoc/>
    public bool Set(T value) => setter.Set(value);
}