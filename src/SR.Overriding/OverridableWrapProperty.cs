using SR.Abstraction;

namespace SR.Overriding;

/// <summary>
/// An overridable property implementation that wraps an existing property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class OverridableWrapProperty<T>(IProperty<T> inner) : OverridableGetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => inner.Get();

    /// <inheritdoc/>
    public bool Set(T value) => inner.Set(value);
}