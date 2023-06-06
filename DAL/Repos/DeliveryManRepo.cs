using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DeliveryManRepo : Repo, IRepoDeliveryMan<DeliveryMan, string, bool>, DAuth<bool>, IChange
    {
        public bool Authenticate(string uname, string password)
        {
            var data = db.DeliveryMans.FirstOrDefault(u => u.Uname.Equals(uname) &&
            u.Password.Equals(password));
            if (data != null)
                return true;
            return false;
        }
        public bool Create(DeliveryMan obj)
        {
            db.DeliveryMans.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.DeliveryMans.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<DeliveryMan> Read()
        {
            return db.DeliveryMans.ToList();
        }

        public DeliveryMan Read(string id)
        {
            return db.DeliveryMans.Find(id);
        }

        public bool Update(DeliveryMan Obj)
        {
            var ex = Read(Obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
        public bool ChangePassword(string Uname, string Password)
        {
            var DeliveryMan = Read(Uname);
            DeliveryMan.Password = Password;
            return db.SaveChanges() > 0;
        }


    }
}
