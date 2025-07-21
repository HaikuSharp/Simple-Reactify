namespace SR.Observing.Abstraction;

/// <summary>
/// Represents a hub that can create publishers for event notification.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface IHub<in TArguments>
{
    /// <summary>
    /// Creates a new publisher instance for broadcasting notifications.
    /// </summary>
    /// <returns>An <see cref="IPublisher{TArguments}"/> instance.</returns>
    IPublisher<TArguments> Publish();
}