using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AccountRepository : BaseRepository<Account, long>
    {
        public AccountRepository(DbSet<Account> dbSet) : base(dbSet)
        {
        }
    }
}
