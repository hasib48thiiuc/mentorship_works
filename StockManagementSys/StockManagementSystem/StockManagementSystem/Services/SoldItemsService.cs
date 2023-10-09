using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Services
{
    public class SoldItemsService : ISoldItemsService
    {
        private readonly IApplicationUnitOfwork _unitOfWork;

        private IMapper _mapper;
        public SoldItemsService(IApplicationUnitOfwork unitOfwork,
                     IMapper mapper)
        {
            _unitOfWork = unitOfwork;
            _mapper = mapper;


        }

        public void Create(List<SoldItemsBO> item)
        {
            List<StockOutItem> items = _mapper.Map<List<SoldItemsBO>,List<StockOutItem>>(item);

            foreach (var item1 in items)
            {
                _unitOfWork._soldItemRepository.Add(item1);
                _unitOfWork.Save();
            }
        }
    }
}
