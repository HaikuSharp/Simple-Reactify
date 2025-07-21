using SR.Abstraction;
using System;

namespace SR.Observing;

/// <summary>
/// An observable property implementation that delegates to function delegates.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class ObservableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : ObservableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => getter();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter(value);
}