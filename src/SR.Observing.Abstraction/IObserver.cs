namespace SR.Observing.Abstraction;

/// <summary>
/// Represents an observer that can react to notifications.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface IObserver<in TArguments> : IReactivable<TArguments>;