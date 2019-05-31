using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public class BaseEntity<T> : IEntity<T>
    {
        public T ID { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? ChangeAt { get; set; }
    }
}
