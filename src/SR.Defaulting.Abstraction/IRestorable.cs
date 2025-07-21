namespace SR.Defaulting.Abstraction;

/// <summary>
/// Represents an object that can be restored to its original or initial state.
/// </summary>
public interface IRestorable
{
    /// <summary>
    /// Restores the object to its original or initial state.
    /// </summary>
    void Restore();
}