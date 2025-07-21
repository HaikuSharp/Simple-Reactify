namespace SR.Abstraction;

public interface IGetter<out T>
{
    T Get();
}
