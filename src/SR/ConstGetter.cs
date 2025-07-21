using SR.Abstraction;

namespace SR;

public sealed class ConstGetter<T>(T value) : IGetter<T>
{
    public T Get() => value;
}
