using SR.Abstraction;

namespace SR;

public sealed class WrapProperty<T>(IProperty<T> inner) : IProperty<T>
{
    public T Get() => inner.Get();

    public bool Set(T value) => inner.Set(value);
}
