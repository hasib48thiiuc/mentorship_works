using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;

namespace StockManagementSystem.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyServices _companyService;
        private IMapper? _mapper;


        public CompanyController(ICompanyServices companyService
                               , IMapper mapper)
        {
            _companyService = companyService;
           _mapper = mapper;

        }
        public IActionResult Index()
        {
            return RedirectToAction("AddCompanyName");
        }
        public IActionResult AddCompanyName()
        {
            List<CompanyBO> list = _companyService.GetAll();
            /// var CategoryEO = _mapper?.Map<IEnumerable<CategoryBO>?, IEnumerable<Category>?>(list);
            var CompanyEO = _mapper.Map<List<CompanyBO>, List<Company>>(list);

            ViewData["Company"] = CompanyEO;

            return View();
        }
        [HttpPost]

        public IActionResult AddCompanyName(Company company)
        {

            CompanyBO catBO = _mapper.Map<CompanyBO>(company);
            _companyService.Create(catBO);

            return RedirectToAction("AddCompanyName");
        }


        public IActionResult EditCompanyName(int id)
        {

            var company = _companyService.GetById(id);


            Company  CATEO = _mapper.Map<Company>(company);

            return View(CATEO);
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

                CompanyBO catBO = _mapper.Map<CompanyBO>(company);
                _companyService.Update(catBO);

                return RedirectToAction("AddCompanyName");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult RemoveCompany(int id)
        {
            _companyService.Delete(id);

            return RedirectToAction("AddCompanyName");
        }

    }
}
