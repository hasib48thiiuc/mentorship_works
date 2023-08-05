using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Repository;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Areas.StockManager.Controllers
{

    [Area("StockManager")]

    public class CompanyController : Controller
    {
        private readonly IApplicationUnitOfwork _unitOfWork;

        public CompanyController(IApplicationUnitOfwork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;


        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCompanyName()
        {


            ViewData["Company"] = _unitOfWork._companies.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult AddCompanyName(Company company)
        {
            _unitOfWork._companies.Add(company);
            _unitOfWork.Save();



            return RedirectToAction("AddCompanyName");
        }

        public IActionResult EditCompanyName(int id)
        {

            var company = _unitOfWork._companies.GetById(id);
           

            return View(company);
        }

        [HttpPost]
        public IActionResult EditCompanyName(Company company)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _unitOfWork._companies.Update(company);
                _unitOfWork.Save();


                return RedirectToAction("AddCompanyName");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult RemoveCompany(int id)
        {
            _unitOfWork._companies.Delete(id);
            _unitOfWork.Save();

            return RedirectToAction("AddCompanyName");
        }


    }
}
