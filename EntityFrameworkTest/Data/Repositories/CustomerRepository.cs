using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, long>
    {
        public CustomerRepository(DbSet<Customer> dbSet) : base(dbSet)
        {
        }
    }
}
