namespace SR.Defaulting;

/// <summary>
/// A simple defaultable property implementation that stores the value directly.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class DefaultableProperty<T>(T value) : DefaultablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => value;

    /// <inheritdoc/>
    public override bool Set(T nvalue)
    {
        value = nvalue;
        return true;
    }
}