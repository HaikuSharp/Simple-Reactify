using SR.Abstraction;
using System;

namespace SR.Observing.Extensions;

/// <summary>
/// Provides extension methods for converting setters to observable versions.
/// </summary>
public static class SetterExtensions
{
    /// <summary>
    /// Wraps an existing setter in an <see cref="ObservableWrapSetter{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value to set.</typeparam>
    /// <param name="inner">The setter to wrap.</param>
    /// <returns>A new observable setter that delegates to the original setter.</returns>
    public static ObservableWrapSetter<T> AsWriteOnlyObservableSetter<T>(this ISetter<T> inner) => new(inner);

    /// <summary>
    /// Creates an observable setter from a setter function delegate.
    /// </summary>
    /// <typeparam name="T">The type of the value to set.</typeparam>
    /// <param name="setter">The setter function to wrap.</param>
    /// <returns>A new observable setter that delegates to the provided function.</returns>
    public static ObservableScriptableSetter<T> AsObservableSetter<T>(this Func<T, bool> setter) => new(setter);
}