using SR.Observing.Abstraction;

namespace SR.Observing.Extensions;

/// <summary>
/// Represents a scope-based unsubscription that automatically resubscribes when disposed.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public readonly struct Unsubscribe<TArguments> : System.IDisposable
{
    private readonly IObservable<TArguments> m_Observable;
    private readonly IObserver<TArguments> m_Observer;

    /// <summary>
    /// Initializes a new instance of the <see cref="Unsubscribe{TArguments}"/> struct.
    /// </summary>
    /// <param name="observable">The observable being managed.</param>
    /// <param name="observer">The observer being temporarily unsubscribed.</param>
    internal Unsubscribe(IObservable<TArguments> observable, IObserver<TArguments> observer)
    {
        m_Observable = observable;
        m_Observer = observer;
    }

    /// <summary>
    /// Resubscribes the observer by calling <see cref="IObservable{TArguments}.Subscribe"/>.
    /// </summary>
    public void Dispose() => m_Observable.Subscribe(m_Observer);
}