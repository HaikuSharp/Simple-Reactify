using SR.Abstraction;

namespace SR;

/// <summary>
/// A decorator that wraps an existing <see cref="ISetter{T}"/> implementation,
/// forwarding all set operations to the inner setter.
/// </summary>
/// <typeparam name="T">The type of value to set.</typeparam>
public sealed class WrapSetter<T>(ISetter<T> inner) : ISetter<T>
{
    /// <inheritdoc/>
    public bool Set(T value) => inner.Set(value);
}