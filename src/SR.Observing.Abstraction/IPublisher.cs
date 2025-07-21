namespace SR.Observing.Abstraction;

public interface IPublisher<in TArguments> : INotifiable<TArguments>;