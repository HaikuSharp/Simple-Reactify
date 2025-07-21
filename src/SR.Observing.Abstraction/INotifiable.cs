namespace SR.Observing.Abstraction;

public interface INotifiable<TArguments>
{
    void Notify(TArguments arguments);
}
