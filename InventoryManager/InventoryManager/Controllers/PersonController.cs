using InventoryManager.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.Controllers
{
    public class PersonController : Controller
    {

        private readonly ApplicationDbContext _ctx;

        public PersonController(ApplicationDbContext ctx)
        {
            _ctx = ctx; 
        }
        public IActionResult Index()
        {

            ViewBag.Greeting = "Hello world";

            ViewData["greeting2"] = "I am using asasd";

            //viewbag can send data controller to view
            TempData["greeting3"] = "i ada asd";
            //tempdata can send to action to action 
            return View();
        }

        
        public IActionResult AddPersons()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddPersons(Person person )
        {

            if(!ModelState.IsValid)
            {
                return View();

            }

            try
            {
                _ctx.Persons.Add(person);

                _ctx.SaveChanges();

                TempData["msg"] = "Added  Successfully";

                return RedirectToAction("AddPersons");
            }


            catch( Exception ex )
            {
                TempData["msg"] = "Could not Add";

                return View();


            }

        }

        public IActionResult DisplayPerson()

        {
            var persons = _ctx.Persons.ToList();

            return View(persons);
        }

        public IActionResult EditPerson(int id)
        {

            var person = _ctx.Persons.Find(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult EditPerson(Person person)
        {

            if (!ModelState.IsValid)
            {
                return View();

            }

            try
            {
                _ctx.Persons.Update(person);

                _ctx.SaveChanges();

                TempData["msg"] = "Updated Successfully";

                return RedirectToAction("DisplayPerson");
            }


            catch (Exception ex)
            {
                TempData["msg"] = "Could not Update";

                return View();


            }

        }

        public IActionResult DeletePerson(int id)

        {

            try
            {
                var person = _ctx.Persons.Find(id);

                if(person != null)
                {
                    _ctx.Persons.Remove(person);
                    _ctx.SaveChanges();
                }
            }

            catch
            {

            }

            return RedirectToAction("DisplayPerson");
        }

    }
}
