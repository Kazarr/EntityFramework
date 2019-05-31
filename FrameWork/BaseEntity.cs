using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseEntity<T> : IEntity<T>
    {
        public T ID { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? ChangeAt { get; set; }
    }
}
