using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Controllers
{
    public class CategoryController : Controller
    {

      
        private readonly ICategoryService _categoryService;
        private IMapper? _mapper;


        public CategoryController(ICategoryService categoryService
                               ,IMapper mapper)
        {
   
            _categoryService = categoryService;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCategory()
        {
            List<CategoryBO> list = _categoryService.GetAll();
          /// var CategoryEO = _mapper?.Map<IEnumerable<CategoryBO>?, IEnumerable<Category>?>(list);
            var CategoryEO = _mapper.Map<List<CategoryBO>, List<Category>>(list);

            ViewData["Category"] = CategoryEO;

            return View();
        }
        [HttpPost]

        public IActionResult AddCategory(Category category)
        {

            CategoryBO catBO = _mapper.Map<CategoryBO>(category);
            _categoryService.Create(catBO);

            return RedirectToAction("AddCategory");
        }


        public IActionResult EditCategoryName(int id)
        {

            var category = _categoryService.GetById(id);

            
                Category CATEO = _mapper.Map<Category>(category);
            
            return View(CATEO);
        }

        [HttpPost]
        public IActionResult EditCategoryName(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {

                CategoryBO catBO = _mapper.Map<CategoryBO>(category);
                _categoryService.Update(catBO);
                
                return RedirectToAction("AddCategory");
            }
            catch
            {
                return View();
            }
        }
      
        public IActionResult RemoveCategory(int id)
        {
            _categoryService.Delete(id);

            return RedirectToAction("AddCategory");
        }

    }

}
