namespace SR.Overriding.Abstraction;

/// <summary>
/// Represents an object that can provide its original, unmodified value.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public interface IOriginal<out T>
{
    /// <summary>
    /// Gets the original, unmodified value.
    /// </summary>
    /// <returns>The original value.</returns>
    T GetOriginal();
}