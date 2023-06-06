using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManageReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ManageReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }

        public static ReviewDTO Get(int id)
        {
            var data = DataAccessFactory.ManageReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }
        public static bool Create(ReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Review>(cart);
            var res = DataAccessFactory.ManageReviewData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(ReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Review>(cart);
            var res = DataAccessFactory.ManageReviewData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int rid)
        {
            return DataAccessFactory.ManageReviewData().Delete(rid);
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
