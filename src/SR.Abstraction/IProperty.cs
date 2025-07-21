namespace SR.Abstraction;

/// <summary>
/// Represents a read-write property that combines both getting and setting capabilities
/// for values of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
public interface IProperty<T> : IGetter<T>, ISetter<T>;
