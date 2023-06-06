using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageReviewRepo : Repo, IRepo<Review, int, bool>
    {
        public bool Create(Review obj)
        {
            db.Reviews.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Reviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Review> Read()
        {
            return db.Reviews.ToList();
        }

        public Review Read(int id)
        {
            return db.Reviews.Find(id);
        }

        public bool Update(Review Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
