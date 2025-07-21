using SR.Abstraction;
using SR.Observing.Abstraction;
using Sugar.Object.Extensions;
using System.Collections.Generic;

namespace SR.Observing;

public abstract class ObservableSetterBase<T> : ISetter<T>, IObservable<T>
{
    private readonly List<IObserver<T>> m_Observers = [];

    public bool Set(T value)
    {
        if(!InternalSet(value)) return false;
        foreach(var observer in m_Observers) observer.Reactive(value);
        return true;
    }

    public void Subscribe(IObserver<T> observer) => m_Observers.Add(observer);

    public void Unsubscribe(IObserver<T> observer) => m_Observers.Remove(observer).Forget();

    protected abstract bool InternalSet(T value);
}