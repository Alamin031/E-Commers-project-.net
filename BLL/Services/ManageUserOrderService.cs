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
    public class ManageUserOrderService
    {
        public static List<User_OrderDTO> Get()
        {
            var data = DataAccessFactory.ManageUserOrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User_Order, User_OrderDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<User_OrderDTO>>(data);
            return mapped;
        }

        public static User_OrderDTO Get(int id)
        {
            var data = DataAccessFactory.ManageUserOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User_Order, User_OrderDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User_OrderDTO>(data);
            return mapped;
        }
        public static bool Create(User_OrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User_OrderDTO, User_Order>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User_Order>(uo);
            var res = DataAccessFactory.ManageUserOrderData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(User_OrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User_OrderDTO, User_Order>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User_Order>(uo);
            var res = DataAccessFactory.ManageUserOrderData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int uid)
        {
            return DataAccessFactory.ManageUserOrderData().Delete1(uid);
        }
    }
}