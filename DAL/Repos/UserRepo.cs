using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepoUsers<User, int, string, decimal, bool>, IAuth<bool>
    {
        public bool Authenticate(string uname, string password)
        {
            var data = db.Users.FirstOrDefault(u => u.uname.Equals(uname) &&
            u.Password.Equals(password));
            if (data != null)
                return true;
            return false;
        }
        public bool Delete(int id)
        {
            var ex = GetAll(id);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<User> Filter(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();

        }

        public User GetAll(int id)
        {
            return db.Users.Find(id);
        }

        public bool Created(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<User> Search(string data)
        {
            throw new NotImplementedException();
        }

        public bool Update(User Obj)
        {
            var ex = GetAll(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<User> GetOrderProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<User> GetOrderProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetProductsInCart(int id)
        {
            throw new NotImplementedException();
        }
    }

}
