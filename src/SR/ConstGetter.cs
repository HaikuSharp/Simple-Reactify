using SR.Abstraction;

namespace SR;

/// <summary>
/// A read-only value holder that always returns the same instance.
/// </summary>
/// <typeparam name="T">The type of the constant value.</typeparam>
public sealed class ConstGetter<T>(T value) : IGetter<T>
{
    /// <inheritdoc/>
    public T Get() => value;
}