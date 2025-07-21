using SR.Abstraction;
using System;

namespace SR.Locking;

/// <summary>
/// A lockable property implementation that delegates operations to function delegates.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class LockableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : LockableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => getter();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter(value);
}