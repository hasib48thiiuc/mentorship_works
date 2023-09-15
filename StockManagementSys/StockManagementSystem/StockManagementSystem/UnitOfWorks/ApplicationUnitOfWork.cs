using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;

namespace StockManagementSystem.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork,IApplicationUnitOfwork
    {
        public IItemRepository _items { get;private set; }
        public ICategoryRepository _categories { get; private set; }
        public ICompanyRepository _companies { get; private set; }

        public ApplicationUnitOfWork(ApplicationDbContext dbContext
            ,ICategoryRepository categories,
            ICompanyRepository companies,
            IItemRepository items) : base((DbContext)dbContext)
        {
            _items = items;
            _categories = categories;
            _companies = companies;
        }
    }
}
