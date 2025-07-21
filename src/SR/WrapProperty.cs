using SR.Abstraction;

namespace SR;

/// <summary>
/// A decorator that wraps an existing <see cref="IProperty{T}"/> implementation,
/// forwarding all get and set operations to the inner property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class WrapProperty<T>(IProperty<T> inner) : IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => inner.Get();

    /// <inheritdoc/>
    public bool Set(T value) => inner.Set(value);
}