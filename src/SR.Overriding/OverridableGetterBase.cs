using SR.Abstraction;
using SR.Overriding.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace SR.Overriding;

/// <summary>
/// Base class for overridable getter implementations providing override functionality.
/// </summary>
/// <typeparam name="T">The type of the value to get.</typeparam>
public abstract class OverridableGetterBase<T> : IGetter<T>, IOverridable<T>
{
    private readonly Dictionary<object, IGetter<T>> m_Overrides = [];

    /// <inheritdoc/>
    public bool HasOverride => m_Overrides.Count > 0;

    /// <inheritdoc/>
    public IGetter<T> GetOverrideGetter(object key) => m_Overrides[key];

    /// <inheritdoc/>
    public bool IsOverride(object key) => m_Overrides.ContainsKey(key);

    /// <inheritdoc/>
    public void Override(object key, IGetter<T> getter) => m_Overrides.Add(key, getter);

    /// <inheritdoc/>
    public void Revert(object key) => m_Overrides.Remove(key);

    /// <inheritdoc/>
    public T Get() => HasOverride ? m_Overrides.First().Value.Get() : InternalGet();

    /// <summary>
    /// When implemented in derived classes, performs the actual get operation.
    /// </summary>
    /// <returns>The underlying value when no override is active.</returns>
    protected abstract T InternalGet();
}