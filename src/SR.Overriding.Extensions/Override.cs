using SR.Overriding.Abstraction;
using System;

namespace SR.Overriding.Extensions;

/// <summary>
/// Represents a scope-based override that automatically reverts when disposed.
/// </summary>
/// <typeparam name="T">The type of the value being overridden.</typeparam>
public readonly struct Override<T> : IDisposable
{
    private readonly IOverridable<T> m_Overridable;
    private readonly object m_Key;

    internal Override(IOverridable<T> overridable, object key)
    {
        m_Overridable = overridable;
        m_Key = key;
    }

    /// <summary>
    /// Reverts the override by calling <see cref="IOverridable{T}.Revert"/>.
    /// </summary>
    public void Dispose() => m_Overridable.Revert(m_Key);
}