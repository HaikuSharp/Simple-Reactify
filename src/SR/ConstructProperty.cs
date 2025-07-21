using SR.Abstraction;

namespace SR;

/// <summary>
/// A composite property implementation that delegates getting and setting operations
/// to separate <see cref="IGetter{T}"/> and <see cref="ISetter{T}"/> implementations.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => getter.Get();

    /// <inheritdoc/>
    public bool Set(T value) => setter.Set(value);
}