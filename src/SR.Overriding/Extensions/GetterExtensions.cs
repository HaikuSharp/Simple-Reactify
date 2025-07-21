using SR.Abstraction;
using System;

namespace SR.Overriding.Extensions;

/// <summary>
/// Provides extension methods for converting getters to overridable versions.
/// </summary>
public static class GetterExtensions
{
    /// <summary>
    /// Wraps an existing getter in an <see cref="OverridableWrapGetter{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value to get.</typeparam>
    /// <param name="inner">The getter to wrap.</param>
    /// <returns>A new overridable getter that delegates to the original getter.</returns>
    public static OverridableWrapGetter<T> AsOverridableGetter<T>(this IGetter<T> inner) => new(inner);

    /// <summary>
    /// Creates an overridable getter from a getter function delegate.
    /// </summary>
    /// <typeparam name="T">The type of the value to get.</typeparam>
    /// <param name="getter">The getter function to wrap.</param>
    /// <returns>A new overridable getter that delegates to the provided function.</returns>
    public static OverridableScriptableGetter<T> AsOverridableGetter<T>(this Func<T> getter) => new(getter);
}