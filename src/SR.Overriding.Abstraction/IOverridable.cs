using SR.Abstraction;

namespace SR.Overriding.Abstraction;

/// <summary>
/// Represents an object whose behavior can be overridden.
/// </summary>
/// <typeparam name="T">The type of the value being overridden.</typeparam>
public interface IOverridable<T>
{
    /// <summary>
    /// Gets a value indicating whether any override is currently active.
    /// </summary>
    /// <value>
    /// <c>true</c> if any override is active; otherwise, <c>false</c>.
    /// </value>
    bool HasOverride { get; }

    /// <summary>
    /// Gets the override getter associated with the specified key.
    /// </summary>
    /// <param name="key">The key of the override to retrieve.</param>
    /// <returns>The override getter associated with the key.</returns>
    IGetter<T> GetOverrideGetter(object key);

    /// <summary>
    /// Determines whether an override exists for the specified key.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>
    /// <c>true</c> if an override exists for the key; otherwise, <c>false</c>.
    /// </returns>
    bool IsOverride(object key);

    /// <summary>
    /// Applies an override using the specified key and getter.
    /// </summary>
    /// <param name="key">The key to identify the override.</param>
    /// <param name="getter">The getter to use for the override.</param>
    void Override(object key, IGetter<T> getter);

    /// <summary>
    /// Removes the override associated with the specified key.
    /// </summary>
    /// <param name="key">The key of the override to remove.</param>
    void Revert(object key);
}