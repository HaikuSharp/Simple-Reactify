using SR.Observing.Abstraction;
using System;

namespace SR.Observing;

public abstract class HubBase<T> : IHub<T>
{
    public IPublisher<T> Publish() => throw new System.NotImplementedException();

    protected abstract void Reactive(T arguments);

    private sealed class Publisher(HubBase<T> hub) : IPublisher<T>
    {
        private readonly WeakReference<HubBase<T>> m_WeakHub = new(hub);

        public void Notify(T arguments)
        {
            if(!m_WeakHub.TryGetTarget(out var hub)) return;
            hub.Reactive(arguments);
        }
    }
}
