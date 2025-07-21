namespace SR.Defaulting;

public sealed class DefaultableProperty<T>(T value) : DefaultablePropertyBase<T>()
{
    public override T Get() => value;

    public override bool Set(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
