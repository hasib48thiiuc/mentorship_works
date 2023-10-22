using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Services
{
    public class StockOutItemService : IStockOutItemService
    {
        private readonly IApplicationUnitOfwork _unitOfWork;

        private IMapper _mapper;
        public StockOutItemService(IApplicationUnitOfwork unitOfwork,
                     IMapper mapper)
        {
            _unitOfWork = unitOfwork;
            _mapper = mapper;


        }

        public void Create(List<StockOutItemBO> item)
        {
            
            List<StockOutItem> items = _mapper.Map<List<StockOutItemBO>,List<StockOutItem>>(item);

            foreach (var item1 in items)
            {
                _unitOfWork._soldItemRepository.Add(item1);
                _unitOfWork.Save();
            }
        }
        
        public List<StockOutItemBO> GetAll()
        {

            List<StockOutItem> items= _unitOfWork._soldItemRepository.GetAll().ToList();
           List<StockOutItemBO> itemBO=_mapper.Map<List<StockOutItem>,List<StockOutItemBO>>(items);

            return itemBO;
           
        }

        public List<StockOutItem>  GetItemQuantity(DateTime formattedDate, DateTime formattedDate2)
        {
            List<StockOutItem> solditems = _unitOfWork._soldItemRepository.SearchByDate(formattedDate, formattedDate2);

            return solditems;
        }
    }
}
