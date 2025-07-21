namespace SR.Defaulting.Abstraction;

public interface IDefaultable<T>
{
    T GetDefault();
}
