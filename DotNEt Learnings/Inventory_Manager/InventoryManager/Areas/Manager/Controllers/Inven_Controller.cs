using Autofac;
using FirstDemo.Web.Models;
using InventoryManager.Areas.Manager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Linq.Dynamic;

namespace InventoryManager.Areas.Manager.Controllers
{

    [Area("Manager")]
    public class Inven_Controller : Controller
    {

        private readonly ILifetimeScope _scope;
        private readonly ILogger<Inven_Controller> _logger;
        public Inven_Controller(ILogger<Inven_Controller> logger, ILifetimeScope scope)
        {
            _scope = scope;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ItemCreateModel model = _scope.Resolve<ItemCreateModel>();
            return View(model);

        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemCreateModel model)
        { 
            if (ModelState.IsValid)
            {
                model.ResolveDependency(_scope);
               await model.CreateItem();
            }
            return View(model);
        }

      /*  [HttpGet]
        public IActionResult GetItem(ItemCreateModel model)
        {
            model.ResolveDependency(_scope);
            model.Name  = (model.GetAllItems().First()).ToString();



            return View(model);


        }*/

        public IActionResult GetItem()
        {

            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ItemListModel>();
            return Json(model.GetPagedItems(dataTableModel));
        }
    }
}
 