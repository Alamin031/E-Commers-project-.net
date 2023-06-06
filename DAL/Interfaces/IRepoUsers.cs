using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{

    public interface IRepoUsers<Type, ID, TEXT, Decimal,  RET>
    {
        RET Created(Type obj);

        List<Type> GetOrderProductDetails();
        Type GetAll(ID id);
        List<Type> GetAll();
        List<Type> GetOrderProductDetails(ID id);
        List<Type> GetProductsInCart(ID id);

        List<Type> Search(TEXT data);
        List<Type> Filter(Decimal min, Decimal max);

        RET Update(Type Obj);

        bool Delete(ID id);
    }
}
