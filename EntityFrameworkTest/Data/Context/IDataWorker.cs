using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public interface IDataWorker: IDisposable, IDBContext
    {
        AdressRepository Adresses { get; }
        AccountRepository Accounts { get; }
        BranchRepository Branches { get; }
        CustomerRepository Customers { get; }
        TransactionRepository Transactions { get; }
    }
}
