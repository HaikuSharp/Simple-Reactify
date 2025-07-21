using SR.Abstraction;
using SR.Defaulting.Abstraction;

namespace SR.Defaulting;

public abstract class DefaultablePropertyBase<T> : IProperty<T>, IDefaultable<T>, IRestorable
{
    private readonly T m_Default;

    protected DefaultablePropertyBase() => m_Default = Get();

    public abstract T Get();

    public abstract bool Set(T value);

    public T GetDefault() => m_Default;

    public void Restore() => Set(m_Default);
}
