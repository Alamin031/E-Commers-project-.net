using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageUserDeliveryManReviewRepo : Repo, IRepoDeliveryMan<DeliveryManReview, int, bool>
    {
        public bool Create(DeliveryManReview obj)
        {
            db.DeliveryManReviews.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.DeliveryManReviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<DeliveryManReview> Read()
        {
            return db.DeliveryManReviews.ToList();
        }

        public DeliveryManReview Read(int id)
        {
            return db.DeliveryManReviews.Find(id);
        }

        public bool Update(DeliveryManReview Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
