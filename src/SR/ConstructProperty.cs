using SR.Abstraction;

namespace SR;

public sealed class ConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : IProperty<T>
{
    public T Get() => getter.Get();

    public bool Set(T value) => setter.Set(value);
}
