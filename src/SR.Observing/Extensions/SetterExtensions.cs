using SR.Abstraction;
using System;

namespace SR.Observing.Extensions;

public static class SetterExtensions
{
    public static ObservableWrapSetter<T> AsWriteOnlyObservableSetter<T>(this ISetter<T> inner) => new(inner);

    public static ObservableScriptableSetter<T> AsObservableSetter<T>(this Func<T, bool> setter) => new(setter);
}