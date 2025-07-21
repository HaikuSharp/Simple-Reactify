using SR.Abstraction;
using System;

namespace SR;

public sealed class ScriptableGetter<T>(Func<T> inner) : IGetter<T>
{
    public T Get() => inner();
}
