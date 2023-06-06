using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class orderinformationsRepo : Repo, IRepoDeliveryMan<orderinformation, int, bool>
    {
        public bool Create(orderinformation obj)
        {
            db.orderinformations.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.orderinformations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<orderinformation> Read()
        {
            return db.orderinformations.ToList();
        }

        public orderinformation Read(int id)
        {
            return db.orderinformations.Find(id);
        }

        public bool Update(orderinformation Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
