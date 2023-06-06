using DAL.Interfaces;
using DAL.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageOrderRepo : Repo, IRepoOrder<Order, int, Order>
    {
        public Order Created(Order obj)
        {
            db.Orders.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderDetails(int id)
        {
            var query = (from userOrder in db.UserOrders
                        where userOrder.Uid == id
                        select userOrder).FirstOrDefault();

             var order = (from o in db.Orders
                         where o.Id == query.Oid
                         select o).ToList();

            return order;
        }

        public List<Order> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public Order Update(Order Obj)
        {
            throw new NotImplementedException();
        }
    }
}
