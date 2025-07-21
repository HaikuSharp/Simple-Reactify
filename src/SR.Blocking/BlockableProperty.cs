namespace SR.Blocking;

/// <summary>
/// A concrete implementation of <see cref="BlockablePropertyBase{T}"/> that stores
/// the property value directly in a field.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class BlockableProperty<T>(T value) : BlockablePropertyBase<T>()
{
    /// <inheritdoc/>
    public override T Get() => value;

    /// <inheritdoc/>
    protected override bool InternalSet(T newValue)
    {
        value = newValue;
        return true;
    }
}