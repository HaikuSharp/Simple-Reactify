using SR.Abstraction;

namespace SR.Locking;

/// <summary>
/// A simple lockable property implementation that stores the value directly.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class LockableProperty<T>(T value) : LockableSetterBase<T>, IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => value;

    /// <inheritdoc/>
    protected override bool InternalSet(T nvalue)
    {
        value = nvalue;
        return true;
    }
}