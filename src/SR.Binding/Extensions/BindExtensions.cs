using SR.Abstraction;
using SR.Binding.Abstraction;

namespace SR.Binding.Extensions;

public static class BindExtensions
{
    public static IBind Bind<T>(this IGetter<T> source, ISetter<T> target) => new Bind<T>(source, target);

    public static IBind Bind<T>(this ISetter<T> target, IGetter<T> source) => new Bind<T>(source, target);
}
