namespace SR.Observing.Abstraction;

public interface INotifiable<in TArguments>
{
    void Notify(TArguments arguments);
}
