using SR.Abstraction;
using SR.Binding.Abstraction;
using System;

namespace SR.Binding;

public class Bind<T>(IGetter<T> source, ISetter<T> target) : IBind
{
    private readonly WeakReference<IGetter<T>> m_WeakSource = new(source);
    private readonly WeakReference<ISetter<T>> m_WeakTarget = new(target);

    public void Sync()
    {
        if(!m_WeakSource.TryGetTarget(out var source)) return;
        if(!m_WeakTarget.TryGetTarget(out var target)) return;
        target.Set(source.Get());
    }
}
