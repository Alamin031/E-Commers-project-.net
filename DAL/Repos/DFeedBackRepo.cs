using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DFeedBackRepo : Repo, IRepoDeliveryMan<DFeedBack, int, bool>
    {
        public bool Create(DFeedBack obj)
        {
            db.DFeedBacks.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int Id)
        {
            var ex = Read(Id);
            db.DFeedBacks.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<DFeedBack> Read()
        {
            return db.DFeedBacks.ToList();
        }

        public DFeedBack Read(int Id)
        {
            return db.DFeedBacks.Find(Id);
        }

        public bool Update(DFeedBack Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
