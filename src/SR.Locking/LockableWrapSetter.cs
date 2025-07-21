using SR.Abstraction;

namespace SR.Locking;

/// <summary>
/// A lockable setter implementation that wraps an existing setter.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public sealed class LockableWrapSetter<T>(ISetter<T> inner) : LockableSetterBase<T>
{
    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner.Set(value);
}