namespace SR.Observing.Abstraction;

public interface IReactivable<in TArguments>
{
    void Reactive(TArguments arguments);
}
