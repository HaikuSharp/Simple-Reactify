using SR.Abstraction;

namespace SR;

/// <summary>
/// A composite property implementation that delegates getting and setting operations
/// to separate <see cref="IGetter{T}"/> and <see cref="ISetter{T}"/> implementations.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : IProperty<T>
{
    /// <summary>
    /// Gets the current value by delegating to the provided <see cref="IGetter{T}"/>.
    /// </summary>
    /// <returns>
    /// The value retrieved from the constructor-provided getter implementation.
    /// </returns>
    public T Get() => getter.Get();

    /// <summary>
    /// Sets the value by delegating to the provided <see cref="ISetter{T}"/>.
    /// </summary>
    /// <param name="value">The value to set.</param>
    /// <returns>
    /// The result from the constructor-provided setter implementation.
    /// <c>true</c> if the value was successfully set; otherwise, <c>false</c>.
    /// </returns>
    public bool Set(T value) => setter.Set(value);
}