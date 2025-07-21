using SR.Abstraction;

namespace SR.Blocking;

/// <summary>
/// A blockable property implementation that wraps an existing <see cref="IProperty{T}"/> instance,
/// adding version tracking and blocking capabilities while delegating all operations to the inner property.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class BlockableWrapProperty<T>(IProperty<T> inner) : BlockablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => inner.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => inner.Set(value);
}