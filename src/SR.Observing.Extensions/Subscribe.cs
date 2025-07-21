using SR.Observing.Abstraction;

namespace SR.Observing.Extensions;

public readonly struct Subscribe<TArguments> : System.IDisposable
{
    private readonly IObservable<TArguments> m_Observable;
    private readonly IObserver<TArguments> m_Observer;

    internal Subscribe(IObservable<TArguments> observable, IObserver<TArguments> observer)
    {
        m_Observable = observable;
        m_Observer = observer;
    }

    public void Dispose() => m_Observable.Unsubscribe(m_Observer);
}
