using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public interface IEntity<T>
    {
        T ID{ get;set;}
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset? ChangeAt { get; set; }

    }
}
