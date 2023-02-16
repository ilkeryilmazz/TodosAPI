using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Task : Entity
    {
       
    
        public int UserId { get; set; }
        public int TaskPriorityId { get; set; }
        public int TaskGroupId { get; set; }
        public int StateId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }



    }

  
}
