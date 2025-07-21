using SR.Abstraction;

namespace SR;

/// <summary>
/// A read-only value holder that always returns the same instance.
/// </summary>
/// <typeparam name="T">The type of the constant value.</typeparam>
public sealed class ConstGetter<T>(T value) : IGetter<T>
{
    /// <summary>
    /// Returns the constant value that was provided during construction.
    /// </summary>
    /// <returns>
    /// The immutable value that this getter was initialized with.
    /// </returns>
    public T Get() => value;
}