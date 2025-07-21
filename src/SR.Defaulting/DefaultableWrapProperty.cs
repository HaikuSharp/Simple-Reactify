using SR.Abstraction;

namespace SR.Defaulting;

public sealed class DefaultableWrapProperty<T>(IProperty<T> inner) : DefaultablePropertyBase<T>()
{
    public override T Get() => inner.Get();

    public override bool Set(T value) => inner.Set(value);
}
