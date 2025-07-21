using SR.Abstraction;

namespace SR;

/// <summary>
/// A simple mutable property implementation that stores a value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public sealed class Property<T>(T value) : IProperty<T>
{
    /// <inheritdoc/>
    public T Get() => value;

    /// <inheritdoc/>
    public bool Set(T newValue)
    {
        value = newValue;
        return true;
    }
}