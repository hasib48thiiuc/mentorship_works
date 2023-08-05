using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Areas.StockManager.Controllers
{

    [Area("StockManager")]

    public class CategoryController : Controller
    {

        private readonly IApplicationUnitOfwork _unitOfWork;
        public CategoryController(IApplicationUnitOfwork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            return View();
        }

       


        public IActionResult AddCategory()
        {


            ViewData["Category"] = _unitOfWork._categories.GetAll();

            return View();
        }
        [HttpPost]

        public IActionResult AddCategory(Category category)
        {
            _unitOfWork._categories.Add(category);
            _unitOfWork.Save();

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
