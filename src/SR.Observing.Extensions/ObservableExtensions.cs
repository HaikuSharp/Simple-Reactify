using SR.Observing.Abstraction;

namespace SR.Observing.Extensions;

/// <summary>
/// Provides extension methods for <see cref="IObservable{TArguments}"/> to enable scope-based subscription management.
/// </summary>
public static class ObservableExtensions
{
    /// <summary>
    /// Subscribes an observer and returns a <see cref="Subscribe{TArguments}"/> that will automatically unsubscribe when disposed.
    /// </summary>
    /// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
    /// <param name="observable">The observable to subscribe to.</param>
    /// <param name="observer">The observer to subscribe.</param>
    /// <returns>A <see cref="Subscribe{TArguments}"/> instance that will unsubscribe on disposal.</returns>
    public static Subscribe<TArguments> SubscribeWithScope<TArguments>(
        this IObservable<TArguments> observable,
        IObserver<TArguments> observer)
    {
        observable.Subscribe(observer);
        return new(observable, observer);
    }

    /// <summary>
    /// Unsubscribes an observer and returns an <see cref="Unsubscribe{TArguments}"/> that will automatically resubscribe when disposed.
    /// </summary>
    /// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
    /// <param name="observable">The observable to manage subscriptions for.</param>
    /// <param name="observer">The observer to temporarily unsubscribe.</param>
    /// <returns>An <see cref="Unsubscribe{TArguments}"/> instance that will resubscribe on disposal.</returns>
    public static Unsubscribe<TArguments> UnsubscribeWithScope<TArguments>(
        this IObservable<TArguments> observable,
        IObserver<TArguments> observer)
    {
        observable.Unsubscribe(observer);
        return new(observable, observer);
    }
}