using SR.Abstraction;

namespace SR.Defaulting;

public sealed class DefaultableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : DefaultablePropertyBase<T>
{
    public override T Get() => getter.Get();

    public override bool Set(T value) => setter.Set(value);
}
