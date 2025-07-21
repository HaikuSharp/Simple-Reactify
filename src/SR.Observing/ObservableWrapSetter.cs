using SR.Abstraction;

namespace SR.Observing;

/// <summary>
/// An observable setter implementation that wraps an existing setter.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public sealed class ObservableWrapSetter<T>(ISetter<T> inner) : ObservableSetterBase<T>
{
    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner.Set(value);
}