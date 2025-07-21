using SR.Abstraction;
using SR.Blocking.Abstraction;
using System;

namespace SR.Blocking;

public abstract class BlockablePropertyBase<T> : IBlockableProperty<T>
{
    private int m_Version;

    public abstract T Get();
    
    public bool Set(T value)
    {
        if(!InternalSet(value)) return false;
        m_Version++;
        return true;
    }

    protected abstract bool InternalSet(T value);

    public IGetter<T> GetBlockedGetter() => new BlockedGetter(this, m_Version);

    private class BlockedGetter(BlockablePropertyBase<T> property, int version) : IGetter<T>
    {
        public T Get() => property.m_Version == version ? property.Get() : throw new InvalidOperationException();
    }
}
