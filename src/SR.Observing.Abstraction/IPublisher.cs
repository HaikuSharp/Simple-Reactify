namespace SR.Observing.Abstraction;

/// <summary>
/// Represents a publisher that can broadcast notifications.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface IPublisher<in TArguments> : INotifiable<TArguments>;