using SR.Abstraction;
using System;

namespace SR.Observing;

/// <summary>
/// An observable setter implementation that delegates to a function delegate.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public sealed class ObservableScriptableSetter<T>(Func<T, bool> inner) : ObservableSetterBase<T>, ISetter<T>
{
    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner(value);
}