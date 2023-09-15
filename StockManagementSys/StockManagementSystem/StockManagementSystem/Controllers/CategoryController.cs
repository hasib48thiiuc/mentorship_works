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
        private IMapper _mapper;


        public CategoryController(ICategoryService categoryService)
        {
   
            _categoryService = categoryService;

        }
        public IActionResult Index()
        {
            return View();
        }




        public IActionResult AddCategory()
        {


            ViewData["Category"] = _categoryService.GetAll();

            return View();
        }
        [HttpPost]

        public IActionResult AddCategory(Category category)
        {

            CategoryBO catBO = _mapper.Map<CategoryBO>(category);
            _categoryService.Create(catBO);

            return RedirectToAction("AddCategory");
        }


      /*  public IActionResult EditCategoryName(int id)
        {

            var category = _categoryService.
            return View(category);
        }*/

      /*  [HttpPost]
        public IActionResult EditCategoryName(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _unitOfWork._categories.Update(category);
                _unitOfWork.Save();

                return RedirectToAction("AddCategory");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult RemoveCategory(int id)
        {
            _unitOfWork._categories.Delete(id);

            _unitOfWork.Save();

            return RedirectToAction("AddCategory");
        }*/

    }

}
