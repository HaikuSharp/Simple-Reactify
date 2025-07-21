namespace SR.Observing.Abstraction;

/// <summary>
/// Represents an object that can react to notifications.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface IReactivable<in TArguments>
{
    /// <summary>
    /// Reacts to the specified notification arguments.
    /// </summary>
    /// <param name="arguments">The notification arguments.</param>
    void Reactive(TArguments arguments);
}