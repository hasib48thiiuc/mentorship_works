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

       

        public void Add(CategoryBO category)
        {
            CategoryEO  catEO=_mapper.Map<CategoryEO>(category);    
            _unitofwork._categories.Add(catEO);
            
            _unitofwork.Save();

        }

        public void Create(CategoryBO category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryBO> GetAll()
        {
            List<CategoryEO> _clist = _unitofwork._categories.GetAll().ToList();             IList<CategoryBO> mappedList = _mapper.Map<List<CategoryEO>, List<CategoryBO>>(_clist);            return mappedList;        }

        public CategoryBO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryBO item)
        {
            throw new NotImplementedException();
        }
    }
    }

