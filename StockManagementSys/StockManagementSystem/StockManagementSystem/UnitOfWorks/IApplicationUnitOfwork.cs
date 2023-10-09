using StockManagementSystem.Repository;

namespace StockManagementSystem.UnitOfWorks
{
    public interface IApplicationUnitOfwork:IUnitOfWork
    {
        public IItemRepository _items { get;  }
        public ICategoryRepository _categories { get;  }
        public ICompanyRepository _companies { get; }

        public ISoldItemRepository _soldItemRepository { get; }

    }
}
