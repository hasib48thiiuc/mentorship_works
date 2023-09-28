using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.UnitOfWorks;
using ItemEO = StockManagementSystem.Models.Domain.Item;
namespace StockManagementSystem.Services
{
    public class ItemServices : IItemServices
    {

        private readonly IApplicationUnitOfwork _unitOfWork; 

        private IMapper _mapper;
        public ItemServices(IApplicationUnitOfwork unitofwork,
            
            
            IMapper mapper)
        {
            _unitOfWork = unitofwork;

            _mapper = mapper;           
        }

        
        public void Create(ItemBO item)
        {
            ItemEO? catEO = _mapper.Map<ItemEO>(item);
            _unitOfWork._items.Add(catEO);
            _unitOfWork.Save();

        }

       public void Delete(int id)
        {

          

        }

        public List<ItemBO> GetAll()
        {
            List<ItemEO> items = _unitOfWork._items.GetAllInItem().ToList();
            List<ItemBO> _clist = _mapper.Map<List<ItemEO>,List<ItemBO>>(items);
            return _clist;        }

        
            public List<ItemBO> GetItemsByCompanyId(int companyId)
            {

            List<ItemEO> items = _unitOfWork._items.GetItemByCompany(companyId).ToList();
            List<ItemBO> _clist = _mapper.Map<List<ItemEO>, List<ItemBO>>(items);
            return _clist;

          }
        

         public ItemBO GetById(int id)
           {
               var Category = _unitOfWork._items.GetById(id);

               ItemBO catBO = _mapper.Map<ItemBO>(Category);

               return catBO;
           }

          /* public void Update(CategoryBO item)
           {
               CategoryEO catEO = _mapper.Map<CategoryEO>(item);

               _unitofwork._categories.Update(catEO);

               _unitofwork.Save();


           }*/
    }
}
