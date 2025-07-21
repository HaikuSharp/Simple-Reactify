using SR.Observing.Abstraction;

namespace SR.Observing.Extensions;

/// <summary>
/// Represents a scope-based subscription that automatically unsubscribes when disposed.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public readonly struct Subscribe<TArguments> : System.IDisposable
{
    private readonly IObservable<TArguments> m_Observable;
    private readonly IObserver<TArguments> m_Observer;

    /// <summary>
    /// Initializes a new instance of the <see cref="Subscribe{TArguments}"/> struct.
    /// </summary>
    /// <param name="observable">The observable being subscribed to.</param>
    /// <param name="observer">The observer being subscribed.</param>
    internal Subscribe(IObservable<TArguments> observable, IObserver<TArguments> observer)
    {
        m_Observable = observable;
        m_Observer = observer;
    }

    /// <summary>
    /// Unsubscribes the observer by calling <see cref="IObservable{TArguments}.Unsubscribe"/>.
    /// </summary>
    public void Dispose() => m_Observable.Unsubscribe(m_Observer);
}