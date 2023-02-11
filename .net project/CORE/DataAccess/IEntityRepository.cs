using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
    }
}
