namespace SR.Observing.Abstraction;

public interface IObservable<TArguments>
{
    void Subscribe(IObserver<TArguments> observer);

    void Unsubscribe(IObserver<TArguments> observer);
}