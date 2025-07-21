using SR.Abstraction;

namespace SR;

/// <summary>
/// A decorator that wraps an existing <see cref="IGetter{T}"/> implementation,
/// forwarding all calls to the inner getter.
/// </summary>
/// <typeparam name="T">The type of value to retrieve.</typeparam>
public sealed class WrapGetter<T>(IGetter<T> inner) : IGetter<T>
{
    /// <summary>
    /// Retrieves a value by delegating to the wrapped getter.
    /// </summary>
    /// <returns>
    /// The value obtained from the inner <see cref="IGetter{T}"/> implementation.
    /// </returns>
    public T Get() => inner.Get();
}