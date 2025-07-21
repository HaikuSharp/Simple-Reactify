using SR.Overriding.Abstraction;
using System;

namespace SR.Overriding.Extensions;

public readonly struct Override<T> : IDisposable
{
    private readonly IOverridable<T> m_Overridable;
    private readonly object m_Key;

    internal Override(IOverridable<T> overridable, object key)
    {
        m_Overridable = overridable;
        m_Key = key;
    }

    public void Dispose() => m_Overridable.Revert(m_Key);
}
