using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;

namespace StockManagementSystem.Controllers
{
    public class StockOutController : Controller
    {

        private readonly ICompanyServices _companyService;
        private readonly ISoldItemsService _soldItemsService;
        private readonly IItemServices _itemServices;

        private IMapper _mapper;

        public StockOutController(IItemServices itemServices,
            ICompanyServices companyService, 
            IMapper mapper,
            ISoldItemsService soldItemsService)
        {
            _mapper = mapper;
            _companyService = companyService;
            _itemServices = itemServices;
            _soldItemsService = soldItemsService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StockOut()
        {
            List<CompanyBO> list = _companyService.GetAll();
            List<ItemBO> itemlist = _itemServices.GetAll();

            CompanyItemViewModel item = new CompanyItemViewModel();
            item.Companies = _mapper.Map<List<CompanyBO>, List<Company>>(list);
            item.Items = _mapper.Map<List<ItemBO>, List<Item>>(itemlist);
            return View(item);
            return View();
        }
        [HttpPost]

        public IActionResult StockOut(List<Item> items)
        {
            return View();
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
        [HttpPost]
        public IActionResult SellItem( [FromBody] StockOutRoot stockOutRoot )
        {


/*            List<SoldItem> itemList = JsonConvert.DeserializeObject<List<SoldItem>>(items);
*/


             foreach(var solditem in stockOutRoot.Items )
             {
                 solditem.Date = DateTime.Now;
                solditem.StockOutType=stockOutRoot.StockOutType;
             }
             List<SoldItemsBO> item = _mapper.Map<List<StockOutItem>, List<SoldItemsBO>>(stockOutRoot.Items );

             _itemServices.DeleteQuantity(item);

             _soldItemsService.Create(item);




            return View();
        }
    }

    public class StockOutRoot
    {



        public List<StockOutItem> Items { get; set; }

        public StockOutType StockOutType { get; set; }  
    }
}
