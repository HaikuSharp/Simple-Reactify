using SR.Abstraction;
using SR.Overriding.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace SR.Overriding;

public abstract class OverridableGetterBase<T> : IGetter<T>, IOverridable<T>
{
    private readonly Dictionary<object, IGetter<T>> m_Overrides = [];

    public bool HasOverride => m_Overrides.Count > 0;

    public IGetter<T> GetOverrideGetter(object key) => m_Overrides[key];

    public bool IsOverride(object key) => m_Overrides.ContainsKey(key);

    public void Override(object key, IGetter<T> getter) => m_Overrides.Add(key, getter);

    public void Revert(object key) => m_Overrides.Remove(key);

    public T Get() => HasOverride ? m_Overrides.First().Value.Get() : InternalGet();

    protected abstract T InternalGet();
}