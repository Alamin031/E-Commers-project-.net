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
    public class ManageProductOrderService
    {
        public static List<ProductOrderDTO> Get()
        {
            var data = DataAccessFactory.ManageProductOrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductOrder, ProductOrderDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductOrderDTO>>(data);
            return mapped;
        }

        public static ProductOrderDTO Get(int id)
        {
            var data = DataAccessFactory.ManageProductOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductOrder, ProductOrderDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductOrderDTO>(data);
            return mapped;
        }
        public static bool Create(ProductOrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductOrderDTO, ProductOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductOrder>(uo);
            var res = DataAccessFactory.ManageProductOrderData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(ProductOrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductOrderDTO, ProductOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductOrder>(uo);
            var res = DataAccessFactory.ManageProductOrderData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int uid)
        {
            return DataAccessFactory.ManageUserOrderData().Delete1(uid);
        }
    }
}
