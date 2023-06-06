using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Delivery_Location_Msg_Repo : Repo, IRepoDeliveryMan<Delivery_Location_Msg, int, bool>
    {
        public bool Create(Delivery_Location_Msg obj)
        {
            db.Delivery_Location_Msgs.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }

        public bool Delete(int Id)
        {
            var ex = Read(Id);
            db.Delivery_Location_Msgs.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Delivery_Location_Msg> Read()
        {
            return db.Delivery_Location_Msgs.ToList();
        }

        public Delivery_Location_Msg Read(int Id)
        {
            return db.Delivery_Location_Msgs.Find(Id);
        }

        public bool Update(Delivery_Location_Msg Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
