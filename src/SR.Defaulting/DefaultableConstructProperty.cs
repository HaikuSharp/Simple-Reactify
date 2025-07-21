using SR.Abstraction;

namespace SR.Defaulting;

/// <summary>
/// A defaultable property implementation that delegates to separate getter and setter instances.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class DefaultableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : DefaultablePropertyBase<T>
{
    /// <inheritdoc/>
    public override T Get() => getter.Get();

    /// <inheritdoc/>
    public override bool Set(T value) => setter.Set(value);
}