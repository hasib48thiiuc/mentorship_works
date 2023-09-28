using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISingletonService _examplesingletonservice1;
        private readonly ISingletonService _examplesingletonservice2;

        private readonly IScopedService _examplescopedservice1;
        private readonly IScopedService _Examplescopedservice2;

        private readonly ITransientService _exampletransientservice1;
        private readonly ITransientService _Exampletransientservice2;
        public HomeController(ILogger<HomeController> logger,
            ITransientService exampletransient1,
            ITransientService exampletransient2,

            IScopedService exmscoped1,
            IScopedService exmscped2,
            ISingletonService exmsngltoneservice1,
            ISingletonService exmsngltoneservice2
            )
        {
            _logger = logger;

            _examplescopedservice1 = exmscoped1;
            _Examplescopedservice2= exmscped2;
            _exampletransientservice1 = exampletransient1;  
            _Exampletransientservice2= exampletransient2;
            _examplesingletonservice1 = exmsngltoneservice1;
            _examplesingletonservice2 = exmsngltoneservice2;
        }

        public IActionResult Index()
        {
            

            var transient1 = _exampletransientservice1.GetDateTime();

            var transient2=_Exampletransientservice2.GetDateTime();

            var scoped1= _examplescopedservice1.GetDateTime();

            var scoped2 = _Examplescopedservice2.GetDateTime();

            var singleton1= _examplesingletonservice1.GetDateTime();

            var singleton2= _examplesingletonservice2.GetDateTime();


            StringBuilder  messages=new StringBuilder();

            messages.Append($"Transient 1: {transient1}\n");
            messages.Append($"Transient 2: {transient2}\n\n");

            messages.Append($"Scoped 1: {scoped1}\n");
            messages.Append($"Scoped 2: {scoped2}\n\n");

            messages.Append($"Singleton 1: {singleton1}\n");
            messages.Append($"Singleton 2: {singleton2}");

            return Ok( messages.ToString() ); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}