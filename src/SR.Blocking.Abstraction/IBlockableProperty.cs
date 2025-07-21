using SR.Abstraction;

namespace SR.Blocking.Abstraction;

public interface IBlockableProperty<T> : IProperty<T> 
{
    IGetter<T> GetBlockedGetter();
}
