namespace SR.Blocking;

public sealed class BlockableProperty<T>(T value) : BlockablePropertyBase<T>()
{
    public override T Get() => value;

    protected override bool InternalSet(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
