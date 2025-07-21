using SR.Abstraction;

namespace SR;

/// <summary>
/// A decorator that wraps an existing <see cref="IProperty{T}"/> implementation,
/// forwarding all get and set operations to the inner property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class WrapProperty<T>(IProperty<T> inner) : IProperty<T>
{
    /// <summary>
    /// Gets the current value by delegating to the wrapped property.
    /// </summary>
    /// <returns>
    /// The value obtained from the inner <see cref="IProperty{T}"/> implementation.
    /// </returns>
    public T Get() => inner.Get();

    /// <summary>
    /// Sets a new value by delegating to the wrapped property.
    /// </summary>
    /// <param name="value">The new value to set.</param>
    /// <returns>
    /// The result from the inner <see cref="IProperty{T}"/> implementation,
    /// indicating whether the value was successfully set.
    /// </returns>
    public bool Set(T value) => inner.Set(value);
}