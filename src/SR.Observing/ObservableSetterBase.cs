using SR.Abstraction;
using SR.Observing.Abstraction;
using System.Collections.Generic;

namespace SR.Observing;

/// <summary>
/// Base class for observable setter implementations providing notification functionality.
/// </summary>
/// <typeparam name="T">The type of the value to set.</typeparam>
public abstract class ObservableSetterBase<T> : ISetter<T>, IObservable<T>
{
    private readonly List<IObserver<T>> m_Observers = [];

    /// <summary>
    /// Sets the value and notifies all observers if successful.
    /// </summary>
    /// <param name="value">The value to set.</param>
    /// <returns>True if the value was successfully set; otherwise false.</returns>
    public bool Set(T value)
    {
        if(!InternalSet(value)) return false;
        foreach(var observer in m_Observers) observer.Reactive(value);
        return true;
    }

    /// <summary>
    /// Subscribes an observer to receive notifications.
    /// </summary>
    /// <param name="observer">The observer to subscribe.</param>
    public void Subscribe(IObserver<T> observer) => m_Observers.Add(observer);

    /// <summary>
    /// Unsubscribes an observer from receiving notifications.
    /// </summary>
    /// <param name="observer">The observer to unsubscribe.</param>
    public void Unsubscribe(IObserver<T> observer) => m_Observers.Remove(observer);

    /// <summary>
    /// When implemented in derived classes, performs the actual set operation.
    /// </summary>
    /// <param name="value">The value to set.</param>
    /// <returns>True if the value was successfully set; otherwise false.</returns>
    protected abstract bool InternalSet(T value);
}