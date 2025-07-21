namespace SR.Overriding.Abstraction;

public interface IOriginal<out T>
{
    T GetOriginal();
}
