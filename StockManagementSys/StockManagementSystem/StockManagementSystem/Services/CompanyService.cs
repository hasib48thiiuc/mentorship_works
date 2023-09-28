using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.UnitOfWorks;
using CompanyEO = StockManagementSystem.Models.Domain.Company;

namespace StockManagementSystem.Services
{
    public class CompanyService:ICompanyServices
    {
        private readonly IApplicationUnitOfwork _unitofwork;
        private IMapper _mapper;
        public CompanyService(IApplicationUnitOfwork unitofwork, IMapper mapper)
        {
            _unitofwork = unitofwork;
            _mapper = mapper;
        }




        public void Create(CompanyBO company)
        {
            CompanyEO? catEO = _mapper.Map<CompanyEO>(company);
            _unitofwork._companies.Add(catEO);

            _unitofwork.Save();
        }

        public void Delete(int id)
        {

            _unitofwork._companies.Delete(id);

            _unitofwork.Save();

        }

        public List<CompanyBO>? GetAll()
        {
            List<CompanyEO>? _clist = _unitofwork._companies.GetAll().ToList();
            List<CompanyBO>? mappedList = _mapper?.Map<List<CompanyEO>?, List<CompanyBO>?>(_clist);
            return mappedList;
        }

        public CompanyBO GetById(int id)
        {
            var Company = _unitofwork._companies.GetById(id);

            CompanyBO companyBO = _mapper.Map<CompanyBO>(Company);

            return companyBO;
        }

        public void Update(CompanyBO item)
        {
            CompanyEO catEO = _mapper.Map<CompanyEO>(item);

            _unitofwork._companies.Update(catEO);

            _unitofwork.Save();


        }
    }
}
