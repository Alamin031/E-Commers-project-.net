using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageFeedBackRepo : Repo, IRepo<FeedBack, int, bool>
    {
        public bool Create(FeedBack obj)
        {
            db.FeedBacks.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.FeedBacks.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<FeedBack> Read()
        {
            return db.FeedBacks.ToList();
        }

        public FeedBack Read(int id)
        {
            return db.FeedBacks.Find(id);
        }

        public bool Update(FeedBack Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
