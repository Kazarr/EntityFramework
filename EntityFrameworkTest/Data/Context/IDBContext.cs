using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public interface IDBContext
    {
         int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
