using StockManagementSystem.BusinessObjects;

namespace StockManagementSystem.Services
{
    public interface ICompanyServices
    {
        void Create(CompanyBO company);
        void Delete(int id);
        List<CompanyBO> GetAll();
        CompanyBO GetById(int id);
        void Update(CompanyBO item);
    }
}
