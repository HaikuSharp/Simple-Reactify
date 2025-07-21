using SR.Abstraction;

namespace SR;

public sealed class Property<T>(T value) : IProperty<T>
{
    public T Get() => value;

    public bool Set(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
