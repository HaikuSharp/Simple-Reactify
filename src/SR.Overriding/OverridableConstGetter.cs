namespace SR.Overriding;

/// <summary>
/// A constant overridable getter implementation that always returns the same value.
/// </summary>
/// <typeparam name="T">The type of the value to get.</typeparam>
public sealed class OverridableConstGetter<T>(T value) : OverridableGetterBase<T>
{
    /// <inheritdoc/>
    protected override T InternalGet() => value;
}