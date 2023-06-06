using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {
        public static IRepoZisan<Admin, int, string, decimal, bool> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepoZisan<Moderator, int, string, decimal, bool> ModeratorData()
        {
            return new ModeratorRepo();
        }
        public static IRepo<SalesReport, int, bool> SalesReportData()
        {
            return new SalesReportRepo();
        }
        public static ISearch<SalesReport> SalesReportSearch()
        {
            return new SalesReportRepo();
        }
        public static IRepo<Seller , string, bool> SellerData()
        {
            return new SellerRepo();
        }
        public static IRepo<Product , int , bool> ProductData()
        {
            return new ProductRepo();
        }

        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepoUsers<User, int, string, decimal, bool> ManageUserData()
        {
            return new UserRepo();
        }
        public static IRepoUsers<Product, int, string, int, Product> ManageProductData()
        {
            return new ManageProductRepo();
        }
        public static IRepoOrder<Order, int, Order> ManageOrderData()
        {
            return new ManageOrderRepo();
        }
        public static IRepo<Review, int, bool> ManageReviewData()
        {
            return new ManageReviewRepo();
        }
        public static IRepoCart<Cart, int, int, Cart> ManageCartData()
        {
            return new ManageCartRepo();
        }
        public static IRepoCart<User_Order, int, int, bool> ManageUserOrderData()
        {
            return new ManageUserOrderRepo();
        }
        public static IRepoCart<ProductOrder, int, int, bool> ManageProductOrderData()
        {
            return new ManageProductOrderRepo();
        }
        public static IRepo<FeedBack, int, bool> ManageFeedBackData()
        {
            return new ManageFeedBackRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepo<OrderDetails, int, bool> OrderDetailsData()
        {
            return new OrderDetailsRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new SellerRepo();
        }
        public static IAuth<bool> AdminAuthData()
        {
            return new AdminRepo();
        }
        public static IAuth<bool> UserAuthData()
        {
            return new UserRepo();
        }
        public static IChange ChangePassData()
        {
            return new SellerRepo();
        }
        public static ITop<OrderDetails> TopSellingReport()
        {
            return new OrderDetailsRepo();
        }
        public static IRepoDeliveryMan<DeliveryMan, string, bool> DeliveryManData()
        {
            return new DeliveryManRepo();
        }
        public static IRepoDeliveryMan<AssignProduct, int, bool> AssignProductData()
        {
            return new AssignProductRepo();
        }
        public static IRepoDeliveryMan<ReciveProduct, int, bool> ReciveProductData()
        {
            return new ReciveProductRepo();
        }
        public static IRepoDeliveryMan<DeliveryManReview, int, bool> DeliveryManReviewData()
        {
            return new ManageUserDeliveryManReviewRepo();
        }
        public static IRepoDeliveryMan<orderinformation, int, bool> orderinformationData()
        {
            return new orderinformationsRepo();
        }
        public static IRepoDeliveryMan<Delivery_Location_Msg, int, bool> Delivery_Location_MsgData()
        {
            return new Delivery_Location_Msg_Repo();
        }
        public static IRepoDeliveryMan<DFeedBack, int, bool> DFeedBackData()
        {
            return new DFeedBackRepo();
        }
        public static DAuth<bool> DeliveryManAuthData()
        {
            return new DeliveryManRepo();
        }
    }
}