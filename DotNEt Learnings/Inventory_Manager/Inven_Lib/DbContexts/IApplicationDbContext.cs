using Microsoft.EntityFrameworkCore;

namespace Inven_Lib.Entities
{
    public interface IApplicationDbContext
    {
        DbSet<Item> Items { get; set; }
    }
}