using SR.Observing.Abstraction;
using System;

namespace SR.Observing;

/// <summary>
/// Base class for observable hubs that manage publishers and subscribers.
/// </summary>
/// <typeparam name="T">The type of the notification arguments.</typeparam>
public abstract class HubBase<T> : IHub<T>
{
    /// <summary>
    /// Creates a new publisher instance for this hub.
    /// </summary>
    /// <returns>An <see cref="IPublisher{T}"/> instance.</returns>
    public IPublisher<T> Publish() => new Publisher(this);

    /// <summary>
    /// When implemented in derived classes, handles notification reactions.
    /// </summary>
    /// <param name="arguments">The notification arguments.</param>
    protected abstract void Reactive(T arguments);

    private sealed class Publisher(HubBase<T> hub) : IPublisher<T>
    {
        private readonly WeakReference<HubBase<T>> m_WeakHub = new(hub);

        /// <inheritdoc/>
        public void Notify(T arguments)
        {
            if(!m_WeakHub.TryGetTarget(out var hub)) return;
            hub.Reactive(arguments);
        }
    }
}