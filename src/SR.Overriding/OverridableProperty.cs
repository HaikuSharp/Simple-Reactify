using SR.Abstraction;

namespace SR.Overriding;

/// <summary>
/// A simple overridable property implementation that stores the value directly.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class OverridableProperty<T>(T value) : OverridableGetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => value;

    /// <inheritdoc/>
    public bool Set(T nvalue)
    {
        value = nvalue;
        return true;
    }
}