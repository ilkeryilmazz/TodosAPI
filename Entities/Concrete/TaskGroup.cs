using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class TaskGroup : Entity
    {
    
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
