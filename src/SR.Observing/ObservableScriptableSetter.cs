using SR.Abstraction;
using System;

namespace SR.Observing;

public sealed class ObservableScriptableSetter<T>(Func<T, bool> inner) : ObservableSetterBase<T>, ISetter<T>
{
    protected override bool InternalSet(T value) => inner(value);
}
