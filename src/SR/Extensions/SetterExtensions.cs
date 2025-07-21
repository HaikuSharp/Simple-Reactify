using SR.Abstraction;
using System;

namespace SR.Extensions;

/// <summary>
/// Provides extension methods for working with <see cref="ISetter{T}"/> implementations.
/// </summary>
public static class SetterExtensions
{
    /// <summary>
    /// Wraps an existing setter in a <see cref="WrapSetter{T}"/> to create a write-only facade.
    /// </summary>
    /// <typeparam name="T">The type of value to set.</typeparam>
    /// <param name="inner">The setter instance to wrap.</param>
    /// <returns>A wrapped setter that provides write-only access.</returns>
    public static WrapSetter<T> AsWriteOnlySetter<T>(this ISetter<T> inner) => new(inner);

    /// <summary>
    /// Converts a delegate function into a <see cref="ScriptableSetter{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of value to set.</typeparam>
    /// <param name="setter">The function delegate to convert.</param>
    /// <returns>A scriptable setter that invokes the provided delegate.</returns>
    public static ScriptableSetter<T> AsSetter<T>(this Func<T, bool> setter) => new(setter);
}