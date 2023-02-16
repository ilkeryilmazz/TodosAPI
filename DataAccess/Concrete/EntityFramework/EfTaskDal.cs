using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = Entities.Concrete.Task;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal:EfEntityRepositoryBase<Task,TodoContext>,ITaskDal
    {
        public EfTaskDal(TodoContext context) : base(context)
        {
        }
    }
}
