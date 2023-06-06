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
    public class AssignProductService
    {
        public static List<AssignProductDTO> Get(int id)
        {
            var data = DataAccessFactory.AssignProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AssignProduct, AssignProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AssignProductDTO>>(data);
            return mapped;
        }

        public static List<AssignProductDTO> Get()
        {
            var data = DataAccessFactory.AssignProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AssignProduct, AssignProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AssignProductDTO>>(data);
            return mapped;
        }




        public static bool Create(AssignProductDTO assignproduct)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AssignProductDTO, AssignProduct>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AssignProduct>(assignproduct);
            var res = DataAccessFactory.AssignProductData().Create(mapped);
            if (res) return true;
            return false;
        }



        public static bool Update(AssignProductDTO AssignProducts)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AssignProductDTO, AssignProduct>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AssignProduct>(AssignProducts);
            var res = DataAccessFactory.AssignProductData().Update(mapped);
            if (res) return true;
            return false;
        }
        public static bool Delete(int ID)
        {
            return DataAccessFactory.AssignProductData().Delete(ID);
        }

    }
}
