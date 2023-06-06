namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Moderators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.AssignProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDescription = c.String(),
                        ProductType = c.String(),
                        DeliveryDate = c.DateTime(nullable: false),
                        Delivery_name = c.String(maxLength: 128),
                        m_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryMen", t => t.Delivery_name)
                .ForeignKey("dbo.Moderators", t => t.m_Id, cascadeDelete: true)
                .Index(t => t.Delivery_name)
                .Index(t => t.m_Id);
            
            CreateTable(
                "dbo.DeliveryMen",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Uname);
            
            CreateTable(
                "dbo.Delivery_Location_Msg",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 100),
                        Status = c.String(nullable: false, maxLength: 100),
                        Delivery_Boy_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryMen", t => t.Delivery_Boy_name)
                .Index(t => t.Delivery_Boy_name);
            
            CreateTable(
                "dbo.DeliveryManReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        u_id = c.Int(nullable: false),
                        o_id = c.Int(nullable: false),
                        Delivery_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryMen", t => t.Delivery_name)
                .ForeignKey("dbo.Orders", t => t.o_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.u_id, cascadeDelete: true)
                .Index(t => t.u_id)
                .Index(t => t.o_id)
                .Index(t => t.Delivery_name);
            
            CreateTable(
                "dbo.DFeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ReviewFeedBack = c.String(nullable: false, maxLength: 150),
                        dmrid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryManReviews", t => t.dmrid, cascadeDelete: true)
                .Index(t => t.dmrid);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderType = c.String(),
                        OrderQuantity = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        SelleBy = c.String(maxLength: 128),
                        ProductId = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SelleBy)
                .Index(t => t.SelleBy)
                .Index(t => t.ProductId)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SelleBy = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        price = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: false)
                .ForeignKey("dbo.Sellers", t => t.SelleBy, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.SelleBy);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 15),
                        ProductCategory = c.String(nullable: false, maxLength: 15),
                        ProductPrice = c.Int(nullable: false),
                        ProdcutQuantity = c.Int(nullable: false),
                        SelleingBy = c.String(maxLength: 128),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sellers", t => t.SelleingBy)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.SelleingBy)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        uid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ReviewFeedBack = c.String(nullable: false, maxLength: 150),
                        rid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reviews", t => t.rid, cascadeDelete: true)
                .Index(t => t.rid);
            
            CreateTable(
                "dbo.User_Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Oid = c.Int(nullable: false),
                        Uid = c.Int(nullable: false),
                        PaymentBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Oid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
                .Index(t => t.Oid)
                .Index(t => t.Uid);
            
            CreateTable(
                "dbo.orderinformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        or_id = c.Int(nullable: false),
                        user_or_id = c.Int(nullable: false),
                        dliverym_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryMen", t => t.dliverym_name)
                .ForeignKey("dbo.Orders", t => t.or_id, cascadeDelete: true)
                .ForeignKey("dbo.User_Order", t => t.user_or_id, cascadeDelete: false)
                .Index(t => t.or_id)
                .Index(t => t.user_or_id)
                .Index(t => t.dliverym_name);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Oid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Oid, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: false)
                .Index(t => t.Oid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Sname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 15),
                        PhoneNumber = c.String(nullable: false),
                        NidNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Sname);
            
            CreateTable(
                "dbo.ReciveProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ap_id = c.Int(nullable: false),
                        dliverym_name = c.String(maxLength: 128),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AssignProducts", t => t.ap_id, cascadeDelete: true)
                .ForeignKey("dbo.DeliveryMen", t => t.dliverym_name)
                .Index(t => t.ap_id)
                .Index(t => t.dliverym_name);
            
            CreateTable(
                "dbo.SalesReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonthName = c.String(),
                        TotalSales = c.Int(nullable: false),
                        ReportedBy = c.Int(nullable: false),
                        Admin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Moderators", t => t.ReportedBy, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .Index(t => t.ReportedBy)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        SellerId = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesReports", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.SalesReports", "ReportedBy", "dbo.Moderators");
            DropForeignKey("dbo.AssignProducts", "m_Id", "dbo.Moderators");
            DropForeignKey("dbo.AssignProducts", "Delivery_name", "dbo.DeliveryMen");
            DropForeignKey("dbo.ReciveProducts", "dliverym_name", "dbo.DeliveryMen");
            DropForeignKey("dbo.ReciveProducts", "ap_id", "dbo.AssignProducts");
            DropForeignKey("dbo.DeliveryManReviews", "u_id", "dbo.Users");
            DropForeignKey("dbo.DeliveryManReviews", "o_id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "SelleBy", "dbo.Sellers");
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "SelleBy", "dbo.Sellers");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "SelleingBy", "dbo.Sellers");
            DropForeignKey("dbo.ProductOrders", "pid", "dbo.Products");
            DropForeignKey("dbo.ProductOrders", "Oid", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.User_Order", "Uid", "dbo.Users");
            DropForeignKey("dbo.orderinformations", "user_or_id", "dbo.User_Order");
            DropForeignKey("dbo.orderinformations", "or_id", "dbo.Orders");
            DropForeignKey("dbo.orderinformations", "dliverym_name", "dbo.DeliveryMen");
            DropForeignKey("dbo.User_Order", "Oid", "dbo.Orders");
            DropForeignKey("dbo.Reviews", "uid", "dbo.Users");
            DropForeignKey("dbo.Reviews", "pid", "dbo.Products");
            DropForeignKey("dbo.FeedBacks", "rid", "dbo.Reviews");
            DropForeignKey("dbo.Carts", "uid", "dbo.Users");
            DropForeignKey("dbo.Carts", "pid", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.DFeedBacks", "dmrid", "dbo.DeliveryManReviews");
            DropForeignKey("dbo.DeliveryManReviews", "Delivery_name", "dbo.DeliveryMen");
            DropForeignKey("dbo.Delivery_Location_Msg", "Delivery_Boy_name", "dbo.DeliveryMen");
            DropForeignKey("dbo.Moderators", "AddedBy", "dbo.Admins");
            DropIndex("dbo.SalesReports", new[] { "Admin_Id" });
            DropIndex("dbo.SalesReports", new[] { "ReportedBy" });
            DropIndex("dbo.ReciveProducts", new[] { "dliverym_name" });
            DropIndex("dbo.ReciveProducts", new[] { "ap_id" });
            DropIndex("dbo.ProductOrders", new[] { "pid" });
            DropIndex("dbo.ProductOrders", new[] { "Oid" });
            DropIndex("dbo.orderinformations", new[] { "dliverym_name" });
            DropIndex("dbo.orderinformations", new[] { "user_or_id" });
            DropIndex("dbo.orderinformations", new[] { "or_id" });
            DropIndex("dbo.User_Order", new[] { "Uid" });
            DropIndex("dbo.User_Order", new[] { "Oid" });
            DropIndex("dbo.FeedBacks", new[] { "rid" });
            DropIndex("dbo.Reviews", new[] { "pid" });
            DropIndex("dbo.Reviews", new[] { "uid" });
            DropIndex("dbo.Carts", new[] { "pid" });
            DropIndex("dbo.Carts", new[] { "uid" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropIndex("dbo.Products", new[] { "SelleingBy" });
            DropIndex("dbo.OrderDetails", new[] { "SelleBy" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "SelleBy" });
            DropIndex("dbo.DFeedBacks", new[] { "dmrid" });
            DropIndex("dbo.DeliveryManReviews", new[] { "Delivery_name" });
            DropIndex("dbo.DeliveryManReviews", new[] { "o_id" });
            DropIndex("dbo.DeliveryManReviews", new[] { "u_id" });
            DropIndex("dbo.Delivery_Location_Msg", new[] { "Delivery_Boy_name" });
            DropIndex("dbo.AssignProducts", new[] { "m_Id" });
            DropIndex("dbo.AssignProducts", new[] { "Delivery_name" });
            DropIndex("dbo.Moderators", new[] { "AddedBy" });
            DropTable("dbo.Tokens");
            DropTable("dbo.SalesReports");
            DropTable("dbo.ReciveProducts");
            DropTable("dbo.Sellers");
            DropTable("dbo.ProductOrders");
            DropTable("dbo.orderinformations");
            DropTable("dbo.User_Order");
            DropTable("dbo.FeedBacks");
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Carts");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.DFeedBacks");
            DropTable("dbo.DeliveryManReviews");
            DropTable("dbo.Delivery_Location_Msg");
            DropTable("dbo.DeliveryMen");
            DropTable("dbo.AssignProducts");
            DropTable("dbo.Moderators");
            DropTable("dbo.Admins");
        }
    }
}
