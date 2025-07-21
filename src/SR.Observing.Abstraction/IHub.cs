namespace SR.Observing.Abstraction;

public interface IHub<in TArguments>
{
    IPublisher<TArguments> Publish();
}
