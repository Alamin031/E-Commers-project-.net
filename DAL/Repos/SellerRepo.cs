using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SellerRepo : Repo, IRepo<Seller, string, bool>, IAuth<bool>, IChange
    {
        public bool Authenticate(string sname, string password)
        {
            var data = db.Sellers.FirstOrDefault(u => u.Sname.Equals(sname) &&
            u.Password.Equals(password));
            if (data != null)
                return true;
            return false;
        }
        public bool Create(Seller obj)
        {
            db.Sellers.Add(obj);
            if (db.SaveChanges () > 0 )
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Sellers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Seller> Read()
        {
            return db.Sellers.ToList();
        }

        public Seller Read(string id)
        {
            return db.Sellers.Find(id);
        }

        public bool Update(Seller Obj)
        {
            var ex = Read(Obj.Sname);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0 )
                return true;
            return false;
        }
        public bool ChangePassword(string Sname, string password)
        {
            var seller = Read(Sname);
            seller.Password = password;
            return db.SaveChanges() > 0;
        }
    }
}
