using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Entities;

namespace Data.Context
{
    public class DataWorker:DbContext, IDataWorker
    {
        private AdressRepository _adresses;
        private AccountRepository _accounts;
        private BranchRepository _branches;
        private CustomerRepository _customers;
        private TransactionRepository _transactions;

        public DataWorker(): base("name =Transformer")
        {

        }

        public AdressRepository Adresses => _adresses ?? (_adresses = new AdressRepository(Set<Adress>()));

        public AccountRepository Accounts => _accounts ?? (_accounts = new AccountRepository(Set<Account>()));

        public BranchRepository Branches => _branches ?? (_branches = new BranchRepository(Set<Branch>()));

        public CustomerRepository Customers => _customers ?? (_customers = new CustomerRepository(Set<Customer>()));

        public TransactionRepository Transactions => _transactions ?? (_transactions = new TransactionRepository(Set<Transaction>()));

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DataWorker).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
