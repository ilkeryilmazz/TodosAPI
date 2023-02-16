using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Task = Entities.Concrete.Task;

namespace Business.Concrete
{
    public class TaskManager:ITaskService
    {
        private readonly ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public List<Task> GetAllTasks()
        {
            var result =  _taskDal.GetAll();
            return result;
        }
    }
}
