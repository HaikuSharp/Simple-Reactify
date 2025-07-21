using SR.Abstraction;

namespace SR.Blocking.Abstraction;

/// <summary>
/// Represents a getter that provides controlled access to a value with access validation capability.
/// </summary>
/// <typeparam name="T">The type of the value being accessed.</typeparam>
public interface IBlockedGetter<out T> : IGetter<T>
{
    /// <summary>
    /// Gets a value indicating whether the getter can currently access the value.
    /// </summary>
    /// <value>
    /// <c>true</c> if the value can be accessed; otherwise, <c>false</c>.
    /// </value>
    bool CanAccess { get; }
}