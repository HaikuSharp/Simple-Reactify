using SR.Abstraction;
using System;

namespace SR;

/// <summary>
/// A getter implementation that retrieves values using a provided delegate function.
/// </summary>
/// <typeparam name="T">The type of value to retrieve.</typeparam>
public sealed class ScriptableGetter<T>(Func<T> inner) : IGetter<T>
{
    /// <inheritdoc/>
    public T Get() => inner();
}