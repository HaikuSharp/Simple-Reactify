namespace SR.Defaulting.Abstraction;

public interface IDefaultable<out T>
{
    T GetDefault();
}
