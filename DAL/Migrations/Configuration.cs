namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PcBuildContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PcBuildContext context)
        {
            for (int i = 1; i <= 5; i++)
            {
                context.Sellers.AddOrUpdate(new Models.Seller
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Sname = "Seller-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    NidNumber = Guid.NewGuid().ToString().Substring(0, 10),

                });
            }
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                context.Products.AddOrUpdate(new Models.Product
                {
                    Id = i,
                    ProductName = Guid.NewGuid().ToString().Substring(0, 10),
                    ProdcutQuantity = random.Next(100, 500),
                    ProductCategory = Guid.NewGuid().ToString().Substring(0, 10),
                    ProductPrice = random.Next(10000, 50000),
                    SelleingBy = "Seller-" + random.Next(1, 6),
                });
            }

            for (int i = 1; i <= 50; i++)
            {
                context.Orders.AddOrUpdate(new Models.Order
                {
                    Id = i,
                    OrderDate = DateTime.Now,
                    OrderType = "Laptop",
                    OrderQuantity = Guid.NewGuid().ToString().Substring(0, 10),
                    Location = Guid.NewGuid().ToString().Substring(0, 10),
                    SelleBy = "Seller-" + random.Next(1, 6),
                    ProductId = random.Next(1, 9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Id = i,
                    uname = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = random.Next(1, 6),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Admins.AddOrUpdate(new Models.Admin
                {

                    Uname = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = random.Next(1, 6),

                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.UserOrders.AddOrUpdate(new Models.User_Order
                {
                    Id = i,
                    Oid = random.Next(1, 9),
                    Uid = random.Next(1, 49),
                    PaymentBy = Guid.NewGuid().ToString().Substring(0, 10),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Carts.AddOrUpdate(new Models.Cart
                {
                    Id = i,
                    uid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                    Quantity = random.Next(1, 15)
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Reviews.AddOrUpdate(new Models.Review
                {
                    Id = i,
                    review = Guid.NewGuid().ToString().Substring(0, 10),
                    date = DateTime.Now,
                    uid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.ProductOrders.AddOrUpdate(new Models.ProductOrder
                {
                    Id = i,
                    Oid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.FeedBacks.AddOrUpdate(new Models.FeedBack
                {
                    Id = i,
                    Date = DateTime.Now,
                    ReviewFeedBack = Guid.NewGuid().ToString().Substring(0, 30),
                    rid = random.Next(1, 49),
                });
            }
            for (int i = 1; i <= 7; i++)
            {
                context.Admins.AddOrUpdate(new Models.Admin
                {
                    Id = i,
                    Uname = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = random.Next(1, 6),
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                context.Moderators.AddOrUpdate(new Models.Moderator
                {
                    Id = i,
                    Uname = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = random.Next(1, 6),
                    AddedBy = random.Next(1, 6),
                });
            }
            for (int i = 1; i <= 40; i++)
            {
                context.SalesReports.AddOrUpdate(new Models.SalesReport
                {
                    Id = i,
                    MonthName = Guid.NewGuid().ToString().Substring(0, 5),
                    TotalSales = random.Next(20000, 50000),
                    ReportedBy = random.Next(1, 11),
                });
            }
            for (int i = 1; i <= 40; i++)
            {
                context.OrderDetails.AddOrUpdate(new Models.OrderDetails
                {
                    Id = i,
                    OrderId = random.Next(1, 50),
                    ProductId = random.Next(1, 10),
                    SelleBy = "Seller-" + random.Next(1, 6),
                    Quantity = random.Next(1, 10),
                    price = Guid.NewGuid().ToString().Substring(0, 5),
                    Status = Guid.NewGuid().ToString().Substring(0, 5),
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                context.DeliveryMans.AddOrUpdate(new Models.DeliveryMan
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Uname = "DeliveryMan-" + i,
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    Address = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),

                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.DeliveryManReviews.AddOrUpdate(new Models.DeliveryManReview
                {
                    Id = i,
                    review = Guid.NewGuid().ToString().Substring(0, 10),
                    date = DateTime.Now,
                    u_id = random.Next(1, 49),
                    o_id = random.Next(1, 49),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.orderinformations.AddOrUpdate(new Models.orderinformation
                {
                    Id = i,
                    or_id = random.Next(1, 49),
                    user_or_id = random.Next(1, 49),

                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.AssignProducts.AddOrUpdate(new Models.AssignProduct
                {
                    Id = i,
                    ProductName = Guid.NewGuid().ToString().Substring(0, 10),
                    ProductDescription = Guid.NewGuid().ToString().Substring(0, 10),
                    ProductType = Guid.NewGuid().ToString().Substring(0, 10),
                    DeliveryDate = DateTime.Now,
                    Delivery_name = "DeliveryMan-" + random.Next(1, 5),
                    m_Id = random.Next(1, 10),


                });
            }

            for (int i = 1; i <= 50; i++)
            {
                context.ReciveProducts.AddOrUpdate(new Models.ReciveProduct
                {
                    ID = i,
                    ap_id = random.Next(1, 40),
                    dliverym_name = "DeliveryMan-" + random.Next(1, 5),

                    status = Guid.NewGuid().ToString().Substring(0, 10),


                });
            }

            for (int i = 1; i <= 50; i++)
            {
                context.Delivery_Location_Msgs.AddOrUpdate(new Models.Delivery_Location_Msg
                {
                    Id = i,
                    Location = Guid.NewGuid().ToString().Substring(0, 10),
                    Status = Guid.NewGuid().ToString().Substring(0, 10),
                    Delivery_Boy_name = "DeliveryMan-" + random.Next(1, 5),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.DFeedBacks.AddOrUpdate(new Models.DFeedBack
                {
                    Id = i,
                    Date = DateTime.Now,
                    ReviewFeedBack = Guid.NewGuid().ToString().Substring(0, 10),
                    dmrid = random.Next(1, 40),
                });
            }

        }
    }
}
