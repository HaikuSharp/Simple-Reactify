using SR.Abstraction;
using System;

namespace SR;

public sealed class ScriptableSetter<T>(Func<T, bool> inner) : ISetter<T>
{
    public bool Set(T value) => inner(value);
}
