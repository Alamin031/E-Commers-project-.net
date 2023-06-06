using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageProductOrderRepo : Repo, IRepoCart<ProductOrder, int, int, bool>
    {
        public bool Create(ProductOrder obj)
        {
            db.ProductOrders.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int uid, int pid)
        {
            throw new NotImplementedException();
        }

        public bool Delete1(int uid)
        {
            var productorder = db.ProductOrders
                            .SingleOrDefault(c => c.Id == uid);
            if (productorder != null)
            {
                db.ProductOrders.Remove(productorder);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<ProductOrder> Read()
        {
            return db.ProductOrders.ToList();
        }

        public ProductOrder Read(int id)
        {
            return db.ProductOrders.Find(id);
        }

        public bool Update(ProductOrder Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
