using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;
using StockManagementSystem.UnitOfWorks;
using System.Runtime.CompilerServices;

namespace StockManagementSystem.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemServices _itemservices;
        private readonly ICompanyServices _companyservices;
        private readonly ICategoryService _categoryservices;


        private IMapper _mapper;

                      
     
        public ItemController(IItemServices itemServices,
            ICategoryService categoryService,
            ICompanyServices companyServices,
            IMapper mapper)
        {
         _itemservices = itemServices;
            _companyservices = companyServices;
          _categoryservices = categoryService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return RedirectToAction("ShowItem");
        }

        public IActionResult AddItem()
        {
            List<CompanyBO> compBO = _companyservices.GetAll();
            List<Company> comps  = _mapper.Map<List<CompanyBO>, List<Company>>(compBO);

            ViewData["comps"] = comps;
            List<CategoryBO> catBO = _categoryservices.GetAll();
            List<Category> cats = _mapper.Map<List<CategoryBO>, List<Category>>(catBO);

            ViewData["Category"] = cats;

            return View();
        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {

            ItemBO? itemBO = _mapper.Map<ItemBO>(item);

            _itemservices.Create(itemBO);
            return RedirectToAction("ShowItem");
        }

       /* public IActionResult EditItem(int id)
        {
            ViewData["comps"] = _UnitOfWork._companies.GetAll();
            ViewData["Category"] = _UnitOfWork._categories.GetAll();
            var item = _UnitOfWork._items.GetById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
            _UnitOfWork._items.Update(item);
            _UnitOfWork.Save();

            return RedirectToAction("ShowItem");
        }*/

        public IActionResult ShowItem()
        {
            List<ItemBO> itemBO = _itemservices.GetAll(); 
            IEnumerable<Item> items = _mapper.Map<List<ItemBO>, List<Item>>(itemBO);


            return View(items);
        }
        public IActionResult SearchItems()
        {

            List<CompanyBO> compBO = _companyservices.GetAll();
            List<Company> comps = _mapper.Map<List<CompanyBO>, List<Company>>(compBO);

            ViewData["comps"] = comps;
         /*   List<CategoryBO> catBO = _categoryservices.GetAll();
            List<Category> cats = _mapper.Map<List<CategoryBO>, List<Category>>(catBO);

            ViewData["Category"] = cats;*/

            return View();
        }

        public JsonResult GetCompanyById(int id)
        {
            List<CategoryBO> items= _itemservices.FindCategory(id);
            List<Category> cats=_mapper.Map<List<CategoryBO>,List<Category>>(items);
           
            return Json(cats);
        }

       


        /* public IActionResult DeleteItem(int id)
         {
             _UnitOfWork._items.Delete(id);

             _UnitOfWork.Save();

             return RedirectToAction("ShowItem");
         }
 */

    }
}
