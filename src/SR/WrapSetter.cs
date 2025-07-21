using SR.Abstraction;

namespace SR;

public sealed class WrapSetter<T>(ISetter<T> inner) : ISetter<T>
{
    public bool Set(T value) => inner.Set(value);
}
