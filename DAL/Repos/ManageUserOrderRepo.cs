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
    internal class ManageUserOrderRepo : Repo, IRepoCart<User_Order, int, int, bool>
    {
        public bool Create(User_Order obj)
        {
            db.UserOrders.Add(obj);
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
            var UserOrder = db.UserOrders
                            .SingleOrDefault(c => c.Id == uid);
            if (UserOrder != null)
            {
                db.UserOrders.Remove(UserOrder);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<User_Order> Read()
        {
            return db.UserOrders.ToList();
        }

        public User_Order Read(int id)
        {
            return db.UserOrders.Find(id);
        }

        public bool Update(User_Order Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
