using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepoZisan<Type, ID, TEXT, Decimal, RET>
    {
        RET Created(Type obj);

        Type GetAll(ID id);
        List<Type> GetAll();
    

        List<Type> Filter(Decimal min, Decimal max);

        RET Update(Type Obj);

        bool Delete(ID id);
    }
}
