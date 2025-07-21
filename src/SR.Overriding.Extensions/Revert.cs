using SR.Abstraction;
using SR.Overriding.Abstraction;
using System;

namespace SR.Overriding.Extensions;

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

    public void Dispose() => m_Overridable.Override(m_Key, m_Getter);
}
