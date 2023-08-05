using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inven_Lib.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
