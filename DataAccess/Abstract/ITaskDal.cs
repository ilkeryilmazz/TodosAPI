using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = Entities.Concrete.Task;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ITaskDal : IEntityRepository<Task>,IAsyncEntityRepository<Task>
    {

    }
}
