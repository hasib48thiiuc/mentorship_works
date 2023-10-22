using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using StockOutType = StockManagementSystem.Models.Domain.StockOutType;

namespace StockManagementSystem.Controllers
{
    public class StockOutController : Controller
    {

        private readonly ICompanyServices _companyService;
        private readonly IStockOutItemService _soldItemsService;
        private readonly IItemServices _itemServices;

        private IMapper _mapper;

        public StockOutController(IItemServices itemServices,
            ICompanyServices companyService,
            IMapper mapper,
            IStockOutItemService soldItemsService)
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
        public IActionResult SellItem([FromBody] StockOutRoot stockOutRoot)
        {


            /*            List<SoldItem> itemList = JsonConvert.DeserializeObject<List<SoldItem>>(items);
            */

            List<StockOutItem> Items = new List<StockOutItem>();

            foreach (var solditem in stockOutRoot.Items)
            {
                solditem.date =DateTime.Now;
                solditem.StockOutType = stockOutRoot.StockOutType;
                Items.Add(solditem);
            }
            List<StockOutItemBO> item = _mapper.Map<List<StockOutItem>, List<StockOutItemBO>>(Items);

            _itemServices.DeleteQuantity(item);

            _soldItemsService.Create(item);

            var message = $"Successfully items are removed";



            return Json(message);
        }

        public IActionResult SearchSellItemByDate()
        {
            List<StockOutItemBO> item1 = _soldItemsService.GetAll();
            List<StockOutItem> items = _mapper.Map<List<StockOutItemBO>, List<StockOutItem>>(item1);

            var distinctDates = items.Select(item => item.date.Date).Distinct().ToList();

            /*
                        List<StockOutItem> distinctItems = items
                            .Where(item => distinctDates.Contains(item.date.Date))*/

            ViewData["solditem"] = distinctDates;
            return View();
        }
        [HttpPost]
        public JsonResult SearchItems([FromBody] SearchByDatesModel jsonstring)
        {


            DateTime date1 = DateTime.ParseExact(jsonstring.Date1, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(jsonstring.Date2, "yyyy-MM-dd", CultureInfo.InvariantCulture);

               List<StockOutItem> items=  _soldItemsService.GetItemQuantity(date1,date2);
            

            return Json(items);
        }
    }

    //for ajax receiving
    
    public class StockOutRoot
    {
        public List<StockOutItem> Items { get; set; }

        public StockOutType StockOutType { get; set; }  
    }
}
