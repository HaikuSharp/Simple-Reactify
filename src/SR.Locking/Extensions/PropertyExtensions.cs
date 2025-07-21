using SR.Abstraction;

namespace SR.Locking.Extensions;

/// <summary>
/// Provides extension methods for converting properties to lockable versions.
/// </summary>
public static class PropertyExtensions
{
    /// <summary>
    /// Wraps an existing property in a <see cref="LockableWrapProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the property value.</typeparam>
    /// <param name="obj">The property to wrap.</param>
    /// <returns>A new lockable property that delegates to the original property.</returns>
    public static LockableWrapProperty<T> AsLockable<T>(this IProperty<T> obj) => new(obj);
}