using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Entities.Concrete.Task;

namespace Business.Abstract
{
    public interface ITaskService
    {
        List<Task> GetAllTasks();
        
    }
}
