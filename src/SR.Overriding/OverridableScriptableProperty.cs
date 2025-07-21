using SR.Abstraction;
using System;

namespace SR.Overriding;

/// <summary>
/// An overridable property implementation that delegates to function delegates.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class OverridableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : OverridableGetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => getter();

    /// <inheritdoc/>
    public bool Set(T value) => setter(value);
}