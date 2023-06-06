using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReciveProductRepo : Repo, IRepoDeliveryMan<ReciveProduct, int, bool>
    {
        public bool Create(ReciveProduct obj)
        {
            db.ReciveProducts.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.ReciveProducts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ReciveProduct> Read()
        {
            return db.ReciveProducts.ToList();
        }

        public ReciveProduct Read(int id)
        {
            return db.ReciveProducts.Find(id);
        }

        public bool Update(ReciveProduct Obj)
        {
            var ex = Read(Obj.ID);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
