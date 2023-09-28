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
            CategoryEO? catEO = _mapper.Map<CategoryEO>(category);
            _unitofwork._categories.Add(catEO);

            _unitofwork.Save();
        }

        public void Delete(int id)
        {

            _unitofwork._categories.Delete(id);

            _unitofwork.Save();

        }

        public List<CategoryBO>? GetAll()
        {
            List<CategoryEO>? _clist = _unitofwork._categories.GetAll().ToList();             List<CategoryBO>? mappedList = _mapper?.Map<List<CategoryEO>?, List<CategoryBO>?>(_clist);            return mappedList;        }

        public CategoryBO GetById(int id)
        {
            var Category=_unitofwork._categories.GetById(id);

            CategoryBO catBO = _mapper.Map<CategoryBO>(Category);

            return catBO;
        }

        public void Update(CategoryBO item)
        {
            CategoryEO catEO = _mapper.Map<CategoryEO>(item);

            _unitofwork._categories.Update(catEO);

            _unitofwork.Save();


        }
    }
    }

