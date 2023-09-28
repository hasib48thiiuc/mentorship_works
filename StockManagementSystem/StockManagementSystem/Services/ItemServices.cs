using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Services
{
    public class ItemServices : IItemServices
    {

        public IApplicationUnitOfwork _unitofwork { get; set; }

        public ItemServices(IApplicationUnitOfwork unitofwork)
        {
            _unitofwork = unitofwork;
            
        }

    }
}
