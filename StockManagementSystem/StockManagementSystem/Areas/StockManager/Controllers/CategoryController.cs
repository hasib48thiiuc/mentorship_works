using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;
using StockManagementSystem.Services;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Areas.StockManager.Controllers
{

    [Area("StockManager")]

    public class CategoryController : Controller
    {

        private readonly IApplicationUnitOfwork _unitOfWork;
        private readonly ICategoryService _categoryService;
        public CategoryController(IApplicationUnitOfwork unitOfWork,ICategoryService categoryService)
        {
            _unitOfWork = unitOfWork;
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
            CategoryBO cat = new CategoryBO();
            cat.Name= category.Name;
             _categoryService.Create(cat);

            return RedirectToAction("AddCategory");
        }


        public IActionResult EditCategoryName(int id)
        {

            var category = _unitOfWork._categories.GetById(id);
            return View(category);
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
        } 

    }
}
