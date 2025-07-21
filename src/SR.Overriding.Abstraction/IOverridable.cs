using SR.Abstraction;

namespace SR.Overriding.Abstraction;

public interface IOverridable<T>
{
    bool HasOverride { get; }

    IGetter<T> GetOverrideGetter(object key);

    bool IsOverride(object key);

    void Override(object key, IGetter<T> getter);

    void Revert(object key);
}
