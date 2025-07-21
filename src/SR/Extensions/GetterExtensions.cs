using SR.Abstraction;
using System;

namespace SR.Extensions;

/// <summary>
/// Provides extension methods for working with <see cref="IGetter{T}"/> implementations.
/// </summary>
public static class GetterExtensions
{
    /// <summary>
    /// Wraps an existing getter in a <see cref="WrapGetter{T}"/> to create a read-only facade.
    /// </summary>
    /// <typeparam name="T">The type of value to retrieve.</typeparam>
    /// <param name="inner">The getter instance to wrap.</param>
    /// <returns>A wrapped getter that provides read-only access.</returns>
    public static WrapGetter<T> AsReadOnlyGetter<T>(this IGetter<T> inner) => new(inner);

    /// <summary>
    /// Converts a delegate function into a <see cref="ScriptableGetter{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of value to retrieve.</typeparam>
    /// <param name="getter">The function delegate to convert.</param>
    /// <returns>A scriptable getter that invokes the provided delegate.</returns>
    public static ScriptableGetter<T> AsGetter<T>(this Func<T> getter) => new(getter);
}