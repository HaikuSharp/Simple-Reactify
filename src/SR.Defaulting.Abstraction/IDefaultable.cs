namespace SR.Defaulting.Abstraction;

/// <summary>
/// Represents an object that can provide a default value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the default value.</typeparam>
public interface IDefaultable<out T>
{
    /// <summary>
    /// Gets the default value of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>The default value.</returns>
    T GetDefault();
}