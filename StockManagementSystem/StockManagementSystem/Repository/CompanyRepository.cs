using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using NuGet.Protocol;
using StockManagementSystem.Models.Domain;
using System.Diagnostics.Contracts;

namespace StockManagementSystem.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }
    }
}
