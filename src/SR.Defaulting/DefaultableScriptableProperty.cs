using System;

namespace SR.Defaulting;

/// <summary>
/// A defaultable property implementation that delegates to function delegates.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class DefaultableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : DefaultablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => getter();

    /// <inheritdoc/>
    public override bool Set(T value) => setter(value);
}