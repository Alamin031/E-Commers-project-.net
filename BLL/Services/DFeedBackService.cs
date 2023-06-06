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
    public class DFeedBackService
    {
        public static List<DFeedBackDTO> Get()
        {
            var data = DataAccessFactory.DFeedBackData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DFeedBack, DFeedBackDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DFeedBackDTO>>(data);
            return mapped;
        }

        public static DFeedBackDTO Get(int Id)
        {
            var data = DataAccessFactory.DFeedBackData().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DFeedBack, DFeedBackDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DFeedBackDTO>(data);
            return mapped;
        }
        public static bool Create(DFeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DFeedBackDTO, DFeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DFeedBack>(cart);
            var res = DataAccessFactory.DFeedBackData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(DFeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DFeedBackDTO, DFeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DFeedBack>(cart);
            var res = DataAccessFactory.DFeedBackData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int Id)
        {
            return DataAccessFactory.DFeedBackData().Delete(Id);
        }



    }
}
