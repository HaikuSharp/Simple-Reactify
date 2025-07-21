using SR.Abstraction;

namespace SR.Blocking;

public sealed class BlockableWrapProperty<T>(IProperty<T> inner) : BlockablePropertyBase<T>()
{
    public override T Get() => inner.Get();

    protected override bool InternalSet(T value) => inner.Set(value);
}
