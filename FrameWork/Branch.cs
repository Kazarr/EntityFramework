using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Branch:BaseEntity<long>
    {
        public string BranchCode { get; set; }
        public string Name { get; set; }

        public long AdressId { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual ICollection<Account> Accounts { get; set; } = new HashSet<Account>();

    }
}
