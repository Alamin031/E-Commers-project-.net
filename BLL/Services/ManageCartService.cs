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
    public class ManageCartService
    {
        public static List<ProductDTO> GetProductsInCart(int id)
        {
            var data = DataAccessFactory.ManageProductData().GetProductsInCart(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static List<CartDTO> Get()
        {
            var data = DataAccessFactory.ManageCartData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CartDTO>>(data);
            return mapped;
        }

        public static CartDTO Get(int id)
        {
            var data = DataAccessFactory.ManageCartData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CartDTO>(data);
            return mapped;
        }
        public static bool Create (CartDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CartDTO, Cart>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Cart>(cart);
            var res = DataAccessFactory.ManageCartData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(CartDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CartDTO, Cart>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Cart>(cart);
            var res = DataAccessFactory.ManageCartData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int uid, int pid)
        {
            return DataAccessFactory.ManageCartData().Delete(uid, pid);
        }
        public static ProductCartDTO GetwithProductInCart(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductCartDTO>();
                c.CreateMap<Cart, CartDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductCartDTO>(data);
            return mapped;
        }
    }
}
