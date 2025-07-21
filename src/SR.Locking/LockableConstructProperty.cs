using SR.Abstraction;

namespace SR.Locking;

/// <summary>
/// A lockable property implementation that delegates operations to separate getter and setter instances.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class LockableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : LockableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => getter.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter.Set(value);
}