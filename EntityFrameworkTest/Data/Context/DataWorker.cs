using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DataWorker:DbContext, IDataWorker
    {
        public DataWorker(): base("name =Transformer")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DataWorker).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
