using SR.Abstraction;

namespace SR;

/// <summary>
/// A simple mutable property implementation that stores a value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class Property<T>(T value) : IProperty<T>
{
    /// <summary>
    /// Gets the current stored value.
    /// </summary>
    /// <returns>The currently stored value.</returns>
    public T Get() => value;

    /// <summary>
    /// Sets a new value for the property.
    /// </summary>
    /// <param name="newValue">The new value to store.</param>
    /// <returns>Always returns <c>true</c> indicating successful assignment.</returns>
    public bool Set(T newValue)
    {
        value = newValue;
        return true;
    }
}