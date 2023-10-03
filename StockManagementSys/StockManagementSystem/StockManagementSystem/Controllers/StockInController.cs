using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;
using StockManagementSystem.Services;

namespace StockManagementSystem.Controllers
{
    public class StockInController : Controller
    {
        private readonly ICompanyServices _companyService;
        private readonly IItemServices _itemServices;
        private IMapper _mapper;

        public StockInController(IItemServices itemServices,ICompanyServices companyService,IMapper mapper)
        {
            _mapper=mapper;
            _companyService=companyService;
            _itemServices=itemServices;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockIn()
        {
            List<CompanyBO> list = _companyService.GetAll();
            List<ItemBO> itemlist= _itemServices.GetAll();

            CompanyItemViewModel item=new CompanyItemViewModel();
             item.Companies = _mapper.Map<List<CompanyBO>, List<Company>>(list);
            item.Items = _mapper.Map<List<ItemBO>, List<Item>>(itemlist);
            return View(item); 
        }

        [HttpPost]
        public IActionResult StockIn(CompanyItemViewModel item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }

            //Update the item's quantity in the database
            _itemServices.UpdateItemQuantity(item.SelectedItemId , item.QuantityToChange );

            // Return to the StockIn page
            return RedirectToAction("StockIn");
        }
        public IActionResult GetItemsByCompanyId(int companyId)
        {
            List<ItemBO> itemBO = _itemServices.GetItemsByCompanyId(companyId);
            IEnumerable<Item> items = _mapper.Map<List<ItemBO>, List<Item>>(itemBO);
            return Json(items);
        }

        public IActionResult UpdateItemDetails(int itemId)
        {
            ItemBO item = _itemServices.GetById(itemId);
            Item item2 = _mapper.Map<Item>(item);
            if (item2 == null)
            {
                return NotFound();
            }
            return Json(item2);
        }

        



    }
}
