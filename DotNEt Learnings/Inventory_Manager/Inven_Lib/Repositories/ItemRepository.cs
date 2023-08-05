using Inven_Lib.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven_Lib.Repositories
{
    public class ItemRepository : Repository<Item, int>, IItemRepository
    {
        public ItemRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }

    }
}
