using System;

namespace SR.Blocking;

/// <summary>
/// A blockable property implementation that delegates operations to function delegates,
/// allowing for scriptable getter and setter behavior.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class BlockableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : BlockablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => getter();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter(value);
}