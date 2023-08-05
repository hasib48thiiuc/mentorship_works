using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Areas.StockManager.Controllers
{
    [Area("StockManager")]
    public class ItemController : Controller
    {
        private readonly IApplicationUnitOfwork _UnitOfWork;

        /*private readonly ICompanyRepository _companyRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IItemRepository _itemRepository;*/
        public ItemController(/*ICompanyRepository companyRepository,
            ICategoryRepository categoryRepository,
            IItemRepository itemRepository,*/IApplicationUnitOfwork unitofwork)
        {
         /*   _companyRepository = companyRepository;
            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;  */ 
            _UnitOfWork = unitofwork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem()
        {
            ViewData["comps"] = _UnitOfWork._companies.GetAll();
            ViewData["Category"] =_UnitOfWork._categories.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {
          
            _UnitOfWork._items.Add(item);
            _UnitOfWork.Save();
            return RedirectToAction("ShowItem");
        }

        public IActionResult EditItem(int id)
        {
            ViewData["comps"] = _UnitOfWork._companies.GetAll();
            ViewData["Category"] = _UnitOfWork._categories.GetAll();
            var item =_UnitOfWork._items.GetById(id);
            return View(item);
        }
       [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
            _UnitOfWork._items.Update(item);
            _UnitOfWork.Save();

            return RedirectToAction("ShowItem");
        }

        public IActionResult ShowItem()
        {
            IEnumerable<Item> items = _UnitOfWork._items.GetAllInItem();

            ViewData["comps"] = _UnitOfWork._companies.GetAll();
            ViewData["Category"] = _UnitOfWork._categories.GetAll();

            return View(items);
        }
        public IActionResult DeleteItem(int id)
        {
            _UnitOfWork._items.Delete(id);

            _UnitOfWork.Save();

            return RedirectToAction("ShowItem");
        }



    }
}
