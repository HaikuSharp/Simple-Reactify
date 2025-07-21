namespace SR.Abstraction;

public interface ISetter<in T>
{
    bool Set(T value);
}
