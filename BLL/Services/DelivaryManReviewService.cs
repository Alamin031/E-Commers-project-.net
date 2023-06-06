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
    public class DelivaryManReviewService
    {
        public static List<DeliveryManReviewDTO> Get()
        {
            var data = DataAccessFactory.DeliveryManReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManReview, DeliveryManReviewDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DeliveryManReviewDTO>>(data);
            return mapped;
        }

        public static DeliveryManReviewDTO Get(int id)
        {
            var data = DataAccessFactory.DeliveryManReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManReview, DeliveryManReviewDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliveryManReviewDTO>(data);
            return mapped;
        }
        public static bool Create(DeliveryManReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManReviewDTO, DeliveryManReview>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliveryManReview>(cart);
            var res = DataAccessFactory.DeliveryManReviewData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(DeliveryManReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManReviewDTO, DeliveryManReview>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliveryManReview>(cart);
            var res = DataAccessFactory.DeliveryManReviewData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int rid)
        {
            return DataAccessFactory.DeliveryManReviewData().Delete(rid);
        }

        //find out order done by which order and user 
        public static ShowReviewDTO GetwithOrders(int id)
        {
            var data = DataAccessFactory.DeliveryManReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManReview, ShowReviewDTO>();
                c.CreateMap<User, DUserDTO>();
                c.CreateMap<Order, OrderDTO>();





            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ShowReviewDTO>(data);
            return mapped;
        }

    }
}
