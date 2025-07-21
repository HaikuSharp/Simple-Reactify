using SR.Abstraction;

namespace SR.Locking;

/// <summary>
/// A lockable property implementation that wraps an existing property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class LockableWrapProperty<T>(IProperty<T> inner) : LockableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => inner.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner.Set(value);
}