namespace SR.Abstraction;

/// <summary>
/// Represents a consumer that can receive and process an instance of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of object to accept.</typeparam>
public interface ISetter<in T>
{
    /// <summary>
    /// Attempts to process the provided value.
    /// </summary>
    /// <param name="value">The instance to process.</param>
    /// <returns>
    /// <c>true</c> if the value was successfully processed;
    /// <c>false</c> if processing failed.
    /// </returns>
    bool Set(T value);
}