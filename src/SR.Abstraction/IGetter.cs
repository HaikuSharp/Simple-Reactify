namespace SR.Abstraction;

/// <summary>
/// Represents a provider that can retrieve an instance of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of object to retrieve.</typeparam>
public interface IGetter<out T>
{
    /// <summary>
    /// Retrieves an instance of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>
    /// An instance of type <typeparamref name="T"/>. The exact behavior depends on
    /// the implementation (could be a new instance, cached instance, etc.).
    /// </returns>
    T Get();
}