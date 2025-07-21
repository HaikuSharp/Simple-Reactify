using SR.Abstraction;

namespace SR.Observing;

/// <summary>
/// A simple observable property implementation that stores the value directly.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ObservableProperty<T>(T value) : ObservableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => value;

    /// <inheritdoc/>
    protected override bool InternalSet(T nvalue)
    {
        value = nvalue;
        return true;
    }
}