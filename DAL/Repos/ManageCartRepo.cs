using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageCartRepo : Repo, IRepoCart<Cart, int, int, Cart>
    {
        public bool Create(Cart obj)
        {
            db.Carts.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int uid, int pid)
        {
            var cartItem = db.Carts
                            .SingleOrDefault(c => c.uid == uid && c.pid == pid);
            if (cartItem != null)
            {
                db.Carts.Remove(cartItem);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete1(int uid)
        {
            throw new NotImplementedException();
        }

        public List<Cart> Read()
        {
            return db.Carts.ToList();
        }

        public Cart Read(int id)
        {
            return db.Carts.Find(id);
        }

        public bool Update(Cart Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
