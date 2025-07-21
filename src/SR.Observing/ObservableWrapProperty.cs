using SR.Abstraction;

namespace SR.Observing;

/// <summary>
/// An observable property implementation that wraps an existing property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ObservableWrapProperty<T>(IProperty<T> inner) : ObservableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => inner.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner.Set(value);
}