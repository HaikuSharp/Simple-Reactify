using SR.Abstraction;

namespace SR;

/// <summary>
/// A decorator that wraps an existing <see cref="ISetter{T}"/> implementation,
/// forwarding all set operations to the inner setter.
/// </summary>
/// <typeparam name="T">The type of value to set.</typeparam>
public sealed class WrapSetter<T>(ISetter<T> inner) : ISetter<T>
{
    /// <summary>
    /// Sets a value by delegating to the wrapped setter.
    /// </summary>
    /// <param name="value">The value to set.</param>
    /// <returns>
    /// The boolean result from the inner <see cref="ISetter{T}"/> implementation,
    /// indicating whether the value was successfully processed.
    /// </returns>
    public bool Set(T value) => inner.Set(value);
}