using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PcBuildContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Order> UserOrders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        public DbSet<DeliveryMan> DeliveryMans { get; set; }

        public DbSet<DeliveryManReview> DeliveryManReviews { get; set; }
        public DbSet<AssignProduct> AssignProducts { get; set; }
        public DbSet<ReciveProduct> ReciveProducts { get; set; }
        public DbSet<orderinformation> orderinformations { get; set; }

        public DbSet<Delivery_Location_Msg> Delivery_Location_Msgs { get; set; }
        public DbSet<DFeedBack> DFeedBacks { get; set; }

    }
}
