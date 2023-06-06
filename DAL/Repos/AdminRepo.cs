using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepoZisan<Admin, int, string, decimal, bool>, IAuth<bool>
    {
        public bool Authenticate(string uname, string password)
        {
            var data = db.Admins.FirstOrDefault(u => u.Uname.Equals(uname) &&
            u.Password.Equals(password));
            if (data != null)
                return true;
            return false;
        }
        public bool Delete(int id)
        {
            var ex = GetAll(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Filter(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();

        }

        public Admin GetAll(int id)
        {
            return db.Admins.Find(id);
        }

        public bool Created(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<Admin> Search(string data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Admin Obj)
        {
            var ex = GetAll(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<Admin> GetOrderProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetOrderProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetProductsInCart(int id)
        {
            throw new NotImplementedException();
        }
    }

}
