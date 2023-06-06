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
    public class ReciveProductService
    {
        public static List<ReciveProductDTO> Get(int ID)
        {
            var data = DataAccessFactory.ReciveProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReciveProduct, ReciveProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReciveProductDTO>>(data);
            return mapped;
        }

        public static List<ReciveProductDTO> Get()
        {
            var data = DataAccessFactory.ReciveProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReciveProduct, ReciveProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReciveProductDTO>>(data);
            return mapped;
        }




        public static bool Create(ReciveProductDTO ReciveProducts)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReciveProductDTO, ReciveProduct>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReciveProduct>(ReciveProducts);
            var res = DataAccessFactory.ReciveProductData().Create(mapped);
            if (res) return true;
            return false;
        }



        public static bool Update(ReciveProductDTO ReciveProducts)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReciveProductDTO, ReciveProduct>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReciveProduct>(ReciveProducts);
            var res = DataAccessFactory.ReciveProductData().Update(mapped);
            if (res) return true;
            return false;
        }
        public static bool Delete(int ID)
        {
            return DataAccessFactory.ReciveProductData().Delete(ID);
        }
    }
}
