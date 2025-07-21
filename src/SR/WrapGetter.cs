using SR.Abstraction;

namespace SR;

public sealed class WrapGetter<T>(IGetter<T> inner) : IGetter<T>
{
    public T Get() => inner.Get();
}
