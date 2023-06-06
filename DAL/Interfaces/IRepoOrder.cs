using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepoOrder<Type, ID, RET>
    {
        RET Created(Type obj);

        List<Type> GetOrderDetails();

        List<Type> GetOrderDetails(ID id);

        RET Update(Type Obj);

        bool Delete(ID id);
    }
}
