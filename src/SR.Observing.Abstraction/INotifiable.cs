namespace SR.Observing.Abstraction;

/// <summary>
/// Represents an object that can receive notifications.
/// </summary>
/// <typeparam name="TArguments">The type of the notification arguments.</typeparam>
public interface INotifiable<in TArguments>
{
    /// <summary>
    /// Notifies the object with the specified arguments.
    /// </summary>
    /// <param name="arguments">The notification arguments.</param>
    void Notify(TArguments arguments);
}