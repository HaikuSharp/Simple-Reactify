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
    /// <inheritdoc/>
    public T Get() => getter();

    /// <inheritdoc/>
    public bool Set(T value) => setter(value);
}