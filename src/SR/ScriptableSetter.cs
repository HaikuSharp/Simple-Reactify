using SR.Abstraction;
using System;

namespace SR;

/// <summary>
/// A setter implementation that delegates value assignment to a provided delegate function.
/// </summary>
/// <typeparam name="T">The type of value to set.</typeparam>
public sealed class ScriptableSetter<T>(Func<T, bool> inner) : ISetter<T>
{
    /// <summary>
    /// Attempts to set a value by invoking the configured delegate.
    /// </summary>
    /// <param name="value">The value to process.</param>
    /// <returns>
    /// The boolean result from the delegate function, indicating whether
    /// the value was successfully processed.
    /// </returns>
    public bool Set(T value) => inner(value);
}