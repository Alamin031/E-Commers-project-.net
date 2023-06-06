using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderDetailsRepo : Repo, IRepo<OrderDetails, int, bool>,ITop<OrderDetails>
    {
        public bool Create(OrderDetails obj)
        {
            db.OrderDetails.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.OrderDetails.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<OrderDetails> GetTop()
        {
           var list=(from x in db.OrderDetails
                     where x.Status.Equals("Approved")
                     select x).ToList();    
            return list;
        }

        public List<OrderDetails> Read()
        {
            return db.OrderDetails.ToList();
        }

        public OrderDetails Read(int id)
        {
            return db.OrderDetails.Find(id);
        }

        public bool Update(OrderDetails Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}

