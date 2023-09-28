using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.UnitOfWorks;
using CategoryEO = StockManagementSystem.Models.Domain.Category;

namespace StockManagementSystem.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IApplicationUnitOfwork _unitofwork;
        private IMapper _mapper;
        public CategoryService(IApplicationUnitOfwork unitofwork,IMapper mapper)
        {
            _unitofwork = unitofwork;
            _mapper = mapper;
        }

        public void Create(CategoryBO category)
        {
            CategoryEO  catEO=_mapper.Map<CategoryEO>(category);    
            _unitofwork._categories.Add(catEO);
            
            _unitofwork.Save();

        }

        public IEnumerable<CategoryBO> GetAllItem()
        {
            var _clist = _unitofwork._categories.GetAll().ToList();            var mappedList = _mapper.Map<List<CompanyEo>, List<CompanyBo>>(_clist);            return mappedList;        }
    }
    }
}
