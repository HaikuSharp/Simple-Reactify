namespace SR.Binding.Abstraction;

/// <summary>
/// Represents an object that can synchronize its state between source and target components.
/// </summary>
public interface IBind
{
    /// <summary>
    /// Synchronizes the current state between bound components.
    /// </summary>
    void Sync();
}