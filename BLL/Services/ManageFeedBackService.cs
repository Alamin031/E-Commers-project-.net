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
    public class ManageFeedBackService
    {
        public static List<FeedBackDTO> Get()
        {
            var data = DataAccessFactory.ManageFeedBackData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FeedBackDTO>>(data);
            return mapped;
        }

        public static FeedBackDTO Get(int id)
        {
            var data = DataAccessFactory.ManageFeedBackData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBackDTO>(data);
            return mapped;
        }
        public static bool Create(FeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBackDTO, FeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBack>(cart);
            var res = DataAccessFactory.ManageFeedBackData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(FeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBackDTO, FeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBack>(cart);
            var res = DataAccessFactory.ManageFeedBackData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int rid)
        {
            return DataAccessFactory.ManageFeedBackData().Delete(rid);
        }
        public static ProductReviewDTO ProductReview(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductReviewDTO>();
                c.CreateMap<Review, ReviewDTO>();
                c.CreateMap<User, UserDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductReviewDTO>(data);
            return mapped;
        }
        public static UserReviewDTO UserReview(int id)
        {
            var data = DataAccessFactory.ManageUserData().GetAll(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserReviewDTO>();
                c.CreateMap<Review, ReviewDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserReviewDTO>(data);
            return mapped;
        }
        public static ReviewFeedBackDTO ReviewFeedBack(int id)
        {
            var data = DataAccessFactory.ManageReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewFeedBackDTO>();
                c.CreateMap<FeedBack, FeedBackDTO>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewFeedBackDTO>(data);
            return mapped;
        }
    }
}