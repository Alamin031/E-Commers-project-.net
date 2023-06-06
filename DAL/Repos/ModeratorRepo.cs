using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ModeratorRepo : Repo, IRepoZisan<Moderator, int, string, decimal, bool>, IAuth<bool>
    {
        public bool Authenticate(string uname, string password)
        {
            var data = db.Moderators.FirstOrDefault(u => u.Uname.Equals(uname) &&
            u.Password.Equals(password));
            if (data != null)
                return true;
            return false;
        }
        public bool Delete(int id)
        {
            var ex = GetAll(id);
            db.Moderators.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Moderator> Filter(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<Moderator> GetAll()
        {
            return db.Moderators.ToList();

        }

        public Moderator GetAll(int id)
        {
            return db.Moderators.Find(id);
        }

        public bool Created(Moderator obj)
        {
            db.Moderators.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<Moderator> Search(string data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Moderator Obj)
        {
            var ex = GetAll(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<Moderator> GetOrderProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Moderator> GetOrderProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Moderator> GetProductsInCart(int id)
        {
            throw new NotImplementedException();
        }
    }

}
