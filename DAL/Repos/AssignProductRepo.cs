using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AssignProductRepo : Repo, IRepoDeliveryMan<AssignProduct, int, bool>

    {
        public bool Create(AssignProduct obj)
        {
            db.AssignProducts.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.AssignProducts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<AssignProduct> Read()
        {
            return db.AssignProducts.ToList();
        }

        public AssignProduct Read(int id)
        {
            return db.AssignProducts.Find(id);
        }

        public bool Update(AssignProduct Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
