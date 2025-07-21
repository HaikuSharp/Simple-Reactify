namespace SR.Observing.Abstraction;

public interface IObserver<in TArguments> : IReactivable<TArguments>;
