using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;

namespace StockManagementSystem.Controllers
{
    public class StockOutController : Controller
    {

        private readonly ICompanyServices _companyService;

        private readonly IItemServices _itemServices;

        private IMapper _mapper;

        public StockOutController(IItemServices itemServices, ICompanyServices companyService, IMapper mapper)
        {
            _mapper = mapper;
            _companyService = companyService;
            _itemServices = itemServices;

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

    }
}
