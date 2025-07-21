using SR.Abstraction;
using SR.Overriding.Abstraction;

namespace SR.Overriding.Extensions;

public static class OverridableExtensions
{
    public static Override<T> OverrideWithScope<T>(this IOverridable<T> overridable, object key, IGetter<T> getter)
    {
        overridable.Override(key, getter);
        return new(overridable, key);
    }

    public static Revert<T> RevertWithScope<T>(this IOverridable<T> overridable, object key)
    {
        var getter = overridable.GetGetter(key);
        overridable.Revert(key);
        return new(overridable, key, getter);
    }
}
