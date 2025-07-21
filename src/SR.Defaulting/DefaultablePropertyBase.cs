using SR.Abstraction;
using SR.Defaulting.Abstraction;

namespace SR.Defaulting;

/// <summary>
/// Base class for defaultable property implementations providing default value tracking.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public abstract class DefaultablePropertyBase<T> : IProperty<T>, IDefaultable<T>, IRestorable
{
    private readonly T m_Default;

    /// <summary>
    /// Initializes a new instance and captures the current value as the default.
    /// </summary>
    protected DefaultablePropertyBase() => m_Default = Get();

    /// <inheritdoc/>
    public abstract T Get();

    /// <inheritdoc/>
    public abstract bool Set(T value);

    /// <inheritdoc/>
    public T GetDefault() => m_Default;

    /// <inheritdoc/>
    public void Restore() => Set(m_Default);
}