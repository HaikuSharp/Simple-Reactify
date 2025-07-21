using SR.Abstraction;
using SR.Binding.Abstraction;

namespace SR.Binding.Extensions;

/// <summary>
/// Provides extension methods for creating bindings between getters and setters.
/// </summary>
public static class BindExtensions
{
    /// <summary>
    /// Creates a binding between a source getter and a target setter.
    /// </summary>
    /// <typeparam name="T">The type of the value being bound.</typeparam>
    /// <param name="source">The source value provider implementing <see cref="IGetter{T}"/>.</param>
    /// <param name="target">The target value receiver implementing <see cref="ISetter{T}"/>.</param>
    /// <returns>
    /// A new <see cref="IBind"/> instance that establishes the binding between the source and target.
    /// </returns>
    public static IBind Bind<T>(this IGetter<T> source, ISetter<T> target) => new Bind<T>(source, target);

    /// <summary>
    /// Creates a binding between a target setter and a source getter (reverse parameter order variant).
    /// </summary>
    /// <typeparam name="T">The type of the value being bound.</typeparam>
    /// <param name="target">The target value receiver implementing <see cref="ISetter{T}"/>.</param>
    /// <param name="source">The source value provider implementing <see cref="IGetter{T}"/>.</param>
    /// <returns>
    /// A new <see cref="IBind"/> instance that establishes the binding between the source and target.
    /// </returns>
    public static IBind Bind<T>(this ISetter<T> target, IGetter<T> source) => new Bind<T>(source, target);
}