using SR.Abstraction;

namespace SR.Observing;

/// <summary>
/// An observable property implementation that delegates to separate getter and setter instances.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ObservableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : ObservableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => getter.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter.Set(value);
}