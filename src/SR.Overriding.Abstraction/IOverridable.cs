using SR.Abstraction;

namespace SR.Overriding.Abstraction;

public interface IOverridable<T>
{
    bool HasOverride { get; }

    bool IsOverride(object key);

    void Override(object key, IGetter<T> getter);

    void Revert(object key);
}
