﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AdressRepository : BaseRepository<Adress, long>
    {
        public AdressRepository(DbSet<Adress> dbSet) : base(dbSet)
        {
        }
    }
}
