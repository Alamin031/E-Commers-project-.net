using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepoCart<Type, UID, PID, RET>
    {
        bool Create(Type obj);

        List<Type> Read();

        Type Read(UID id);

        bool Update(Type Obj);

        bool Delete(UID uid, PID pid);
        bool Delete1(UID uid);
    }
}
