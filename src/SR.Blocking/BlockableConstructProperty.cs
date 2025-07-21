using SR.Abstraction;

namespace SR.Blocking;

/// <summary>
/// A blockable property implementation that delegates get and set operations
/// to separate <see cref="IGetter{T}"/> and <see cref="ISetter{T}"/> instances.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class BlockableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : BlockablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => getter.Get();

    /// <inheritdoc/>
    protected override bool InternalSet(T value) => setter.Set(value);
}