using System;

namespace SR.Overriding;

/// <summary>
/// An overridable getter implementation that delegates to a function delegate.
/// </summary>
/// <typeparam name="T">The type of the value to get.</typeparam>
public sealed class OverridableScriptableGetter<T>(Func<T> inner) : OverridableGetterBase<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => inner();
}