using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class TaskPriority :Entity
    {
    
        public int Level { get; set; }
        public string Name { get; set; }
    }
}
