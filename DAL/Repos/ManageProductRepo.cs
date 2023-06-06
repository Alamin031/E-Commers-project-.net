using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageProductRepo : Repo, IRepoUsers<Product, int, string, int, Product>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Filter(int min, int max)
        {
            var products = db.Products.Where(p => p.ProductPrice >= min && p.ProductPrice <= max)
            .ToList();
            return products;
        }


        public List<Product> GetOrderProductDetails(int id)
        {
            var query = (from userOrder in db.UserOrders
                         where userOrder.Uid == id
                         select userOrder).FirstOrDefault();

            var order = (from uo in db.Orders
                         where uo.Id == query.Oid
                         select uo).FirstOrDefault();

            var productid = (from po in db.ProductOrders
                             where po.Oid == order.Id
                             select po).FirstOrDefault();

            var Product = (from p in db.Products
                           where p.Id == productid.pid
                           select p).ToList();
            return Product;
        }

        public Product Created(Product obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string data)
        {
            var products = db.Products.Where(p => p.ProductName.Contains(data)).ToList();
            return products;
        }

        public Product Update(Product Obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetOrderProductDetails()
        {
            throw new NotImplementedException();
        }

        public Product GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductsInCart(int userId)
        {
            var productsInCart = db.Carts
                                    .Where(c => c.uid == userId)
                                    .Select(c => c.product)
                                    .ToList();

            return productsInCart;
        }
    }
}
