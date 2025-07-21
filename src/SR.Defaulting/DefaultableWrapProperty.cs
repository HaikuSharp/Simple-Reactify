using SR.Abstraction;

namespace SR.Defaulting;

/// <summary>
/// A defaultable property implementation that wraps an existing property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class DefaultableWrapProperty<T>(IProperty<T> inner) : DefaultablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => inner.Get();

    /// <inheritdoc/>
    public override bool Set(T value) => inner.Set(value);
}