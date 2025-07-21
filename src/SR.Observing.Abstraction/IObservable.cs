namespace SR.Observing.Abstraction;

/// <summary>
/// Represents an observable object that can be subscribed to.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface IObservable<TArguments>
{
    /// <summary>
    /// Subscribes an observer to receive notifications.
    /// </summary>
    /// <param name="observer">The observer to subscribe.</param>
    void Subscribe(IObserver<TArguments> observer);

    /// <summary>
    /// Unsubscribes an observer from receiving notifications.
    /// </summary>
    /// <param name="observer">The observer to unsubscribe.</param>
    void Unsubscribe(IObserver<TArguments> observer);
}