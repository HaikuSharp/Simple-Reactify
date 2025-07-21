using SR.Observing.Abstraction;

namespace SR.Observing.Extensions;

public static class ObservableExtensions
{
    public static Subscribe<TArguments> SubscribeWithScope<TArguments>(this IObservable<TArguments> observable, IObserver<TArguments> observer)
    {
        observable.Subscribe(observer);
        return new(observable, observer);
    }

    public static Unsubscribe<TArguments> UnsubscribeWithScope<TArguments>(this IObservable<TArguments> observable, IObserver<TArguments> observer)
    {
        observable.Unsubscribe(observer);
        return new(observable, observer);
    }
}
