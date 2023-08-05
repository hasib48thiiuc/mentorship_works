using Inven_Lib.Repositories;

namespace Inven_Lib.UnitOfWork
{
    public interface IApplicationUnitOfWork:IUnitOfWork
    {
        IItemRepository Items { get;  }
    }
}