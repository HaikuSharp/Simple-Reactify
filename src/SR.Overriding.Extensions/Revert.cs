using SR.Abstraction;
using SR.Overriding.Abstraction;
using System;

namespace SR.Overriding.Extensions;

/// <summary>
/// Represents a scope-based revert that automatically reapplies the override when disposed.
/// </summary>
/// <typeparam name="T">The type of the value being overridden.</typeparam>
public readonly struct Revert<T> : IDisposable
{
    private readonly IOverridable<T> m_Overridable;
    private readonly object m_Key;
    private readonly IGetter<T> m_Getter;

    internal Revert(IOverridable<T> overridable, object key, IGetter<T> getter)
    {
        m_Overridable = overridable;
        m_Key = key;
        m_Getter = getter;
    }

    /// <summary>
    /// Reapplies the override by calling <see cref="IOverridable{T}.Override"/>.
    /// </summary>
    public void Dispose() => m_Overridable.Override(m_Key, m_Getter);
}