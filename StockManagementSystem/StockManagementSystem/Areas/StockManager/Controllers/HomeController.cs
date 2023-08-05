using Microsoft.AspNetCore.Mvc;

namespace StockManagementSystem.Areas.StockManager.Controllers
{

    [Area("StockManager")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
