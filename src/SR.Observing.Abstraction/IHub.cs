namespace SR.Observing.Abstraction;

public interface IHub<TArguments>
{
    IPublisher<TArguments> Publish();
}
