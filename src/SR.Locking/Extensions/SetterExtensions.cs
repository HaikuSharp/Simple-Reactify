using SR.Abstraction;
using System;

namespace SR.Locking.Extensions;

/// <summary>
/// Provides extension methods for converting setters to lockable versions.
/// </summary>
public static class SetterExtensions
{
    /// <summary>
    /// Wraps an existing setter in a <see cref="LockableWrapSetter{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value to set.</typeparam>
    /// <param name="inner">The setter to wrap.</param>
    /// <returns>A new lockable setter that delegates to the original setter.</returns>
    public static LockableWrapSetter<T> AsWriteOnlyLockableSetter<T>(this ISetter<T> inner) => new(inner);

    /// <summary>
    /// Creates a lockable setter from a setter function delegate.
    /// </summary>
    /// <typeparam name="T">The type of the value to set.</typeparam>
    /// <param name="setter">The setter function to wrap.</param>
    /// <returns>A new lockable setter that delegates to the provided function.</returns>
    public static LockableScriptableSetter<T> AsLockableSetter<T>(this Func<T, bool> setter) => new(setter);
}