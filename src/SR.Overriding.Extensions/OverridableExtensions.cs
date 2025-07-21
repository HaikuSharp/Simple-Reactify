using SR.Abstraction;
using SR.Overriding.Abstraction;

namespace SR.Overriding.Extensions;

/// <summary>
/// Provides extension methods for scope-based override management.
/// </summary>
public static class OverridableExtensions
{
    /// <summary>
    /// Applies an override and returns an <see cref="Override{T}"/> that will automatically revert when disposed.
    /// </summary>
    /// <typeparam name="T">The type of the value being overridden.</typeparam>
    /// <param name="overridable">The overridable object.</param>
    /// <param name="key">The key to identify the override.</param>
    /// <param name="getter">The getter to use for the override.</param>
    /// <returns>An <see cref="Override{T}"/> instance that will revert on disposal.</returns>
    public static Override<T> OverrideWithScope<T>(this IOverridable<T> overridable, object key, IGetter<T> getter)
    {
        overridable.Override(key, getter);
        return new(overridable, key);
    }

    /// <summary>
    /// Reverts an override and returns a <see cref="Revert{T}"/> that will automatically reapply when disposed.
    /// </summary>
    /// <typeparam name="T">The type of the value being overridden.</typeparam>
    /// <param name="overridable">The overridable object.</param>
    /// <param name="key">The key of the override to revert.</param>
    /// <returns>A <see cref="Revert{T}"/> instance that will reapply on disposal.</returns>
    public static Revert<T> RevertWithScope<T>( this IOverridable<T> overridable, object key)
    {
        var getter = overridable.GetOverrideGetter(key);
        overridable.Revert(key);
        return new(overridable, key, getter);
    }
}