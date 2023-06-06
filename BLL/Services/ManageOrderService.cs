using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManageOrderService
    {
        public static List<OrderDTO> UserOrderDetails(int id)
        {
            var data = DataAccessFactory.ManageOrderData().GetOrderDetails(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDTO>>(data);
            return mapped;
        }
        public static List<ProductDTO> UserOrderProductDetails(int id)
        {
            var data = DataAccessFactory.ManageProductData().GetOrderProductDetails(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static ProductOrderDetailsDTO GetwithProduct(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductOrderDetailsDTO>();
                c.CreateMap<Order, OrderDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductOrderDetailsDTO>(data);
            return mapped;
        }
    }
}
