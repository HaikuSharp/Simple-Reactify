using SR.Abstraction;

namespace SR.Blocking.Abstraction;

/// <summary>
/// Represents a property that can be blocked, preventing direct access to its value
/// while providing controlled access through a blocked getter interface.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public interface IBlockableProperty<T> : IProperty<T>
{
    /// <summary>
    /// Gets a blocked version of the property getter that may implement
    /// additional access control or validation logic.
    /// </summary>
    /// <returns>
    /// An <see cref="IGetter{T}"/> implementation that provides controlled
    /// access to the property value.
    /// </returns>
    IGetter<T> GetBlockedGetter();
}
