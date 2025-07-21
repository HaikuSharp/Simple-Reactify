namespace SR.Observing.Abstraction;

public interface IReactivable<TArguments>
{
    void Reactive(TArguments arguments);
}
