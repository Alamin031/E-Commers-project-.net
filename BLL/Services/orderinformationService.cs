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
    public class orderinformationService
    {
        public static List<orderinformationDTO> Get()
        {
            var data = DataAccessFactory.orderinformationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<orderinformation, orderinformationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<orderinformationDTO>>(data);
            return mapped;
        }

        public static orderinformationDTO Get(int id)
        {
            var data = DataAccessFactory.orderinformationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<orderinformation, orderinformationDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<orderinformationDTO>(data);
            return mapped;
        }
        //find out order done by which order and user 
        public static showOrderDTO GetwithOrders(int id)
        {
            var data = DataAccessFactory.orderinformationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<orderinformation, showOrderDTO>();
                c.CreateMap<Order, OrderDTO>();
                c.CreateMap<User_Order, User_OrderDTO>();



            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<showOrderDTO>(data);
            return mapped;
        }
        public static bool Create(orderinformationDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<orderinformationDTO, orderinformation>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<orderinformation>(order);
            var res = DataAccessFactory.orderinformationData().Create(mapped);
            if (res) return true;
            return false;
        }
        public static bool Update(orderinformationDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<orderinformationDTO, orderinformation>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<orderinformation>(order);
            var res = DataAccessFactory.orderinformationData().Update(mapped);
            if (res) return true;
            return false;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.orderinformationData().Delete(id);
        }
    }
}
