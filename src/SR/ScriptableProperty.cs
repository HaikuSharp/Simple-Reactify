using SR.Abstraction;
using System;

namespace SR;

/// <summary>
/// A property implementation that delegates getting and setting operations
/// to provided delegate functions.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : IProperty<T>
{
    /// <summary>
    /// Gets the current value by invoking the getter delegate.
    /// </summary>
    /// <returns>
    /// The result of the getter function provided during construction.
    /// </returns>
    public T Get() => getter();

    /// <summary>
    /// Sets the value by invoking the setter delegate.
    /// </summary>
    /// <param name="value">The new value to set.</param>
    /// <returns>
    /// The boolean result from the setter function,
    /// typically indicating whether the value was accepted.
    /// </returns>
    public bool Set(T value) => setter(value);
}