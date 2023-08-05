using InventoryManagement.Models.Domain;
using InventoryManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository repo)
        {
            _itemRepository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem()
        {

            return View();
        }

        [HttpPost] 
        public IActionResult AddItem(Item item)
        {

            if(!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _itemRepository.AddItem(item);
                _itemRepository.SaveItem();

                TempData["msg"] = "Item Added Successfully";

                return RedirectToAction("AddItem");

            }
            catch(Exception ex)
            {

                TempData["msg"] = "Could not be added";

                return View();


            }

        }

        public IActionResult ShowItem()
        {
            var items=_itemRepository.ShowItem().ToList(); 
            return View(items);  
        }

        public IActionResult EditItem(int id)
        {
            var items = _itemRepository.FindItem(id);
            return View(items);
        }

        [HttpPost]
        public IActionResult EditItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _itemRepository.EditItem(item);
                _itemRepository.SaveItem();

                TempData["msg"] = "Item Updated Successfully";

                return RedirectToAction("ShowItem");

            }
            catch (Exception ex)
            {

                TempData["msg"] = "Could not be Updated";

                return View();


            }
        }



        public IActionResult DeleteItem(int id)
        {

            try
            {
                Item item = (Item)_itemRepository.FindItem(id);

                if(item != null)
                {
                    _itemRepository.DeleteItem(item);
                    _itemRepository.SaveItem();
                }
            }

            catch (Exception ex)
            {


            }

            return RedirectToAction("ShowItem");
        }








    }
}
