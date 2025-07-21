using SR.Abstraction;
using System;

namespace SR.Locking;

/// <summary>
/// A lockable setter implementation that delegates to a function delegate.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public sealed class LockableScriptableSetter<T>(Func<T, bool> inner) : LockableSetterBase<T>, ISetter<T>
{
    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner(value);
}