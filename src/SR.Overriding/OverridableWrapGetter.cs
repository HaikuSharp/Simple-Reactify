using SR.Abstraction;

namespace SR.Overriding;

/// <summary>
/// An overridable getter implementation that wraps an existing getter.
/// </summary>
/// <typeparam name="T">The type of the value to get.</typeparam>
public sealed class OverridableWrapGetter<T>(IGetter<T> inner) : OverridableGetterBase<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => inner.Get();
}