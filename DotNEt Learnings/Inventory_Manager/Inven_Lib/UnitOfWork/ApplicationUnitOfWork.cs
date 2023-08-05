using Inven_Lib.Entities;
using Inven_Lib.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven_Lib.UnitOfWork
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IItemRepository Items { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IItemRepository itemRepository) : base((DbContext)dbContext)
        {
           
           Items = itemRepository;
        }
    }
}
