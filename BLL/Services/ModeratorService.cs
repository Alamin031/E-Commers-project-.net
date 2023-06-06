using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ManageModeratorService
    {
        public static List<ModeratorDTO> Get()
        {
            var data = DataAccessFactory.ModeratorData().GetAll();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ModeratorDTO>>(data);
            return mapped;
        }

        public static ModeratorDTO Get(int id)
        {
            var data = DataAccessFactory.ModeratorData().GetAll(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ModeratorDTO>(data);
            return mapped;
        }
        public static ModeratorSalesReportDTO GetwithSalesReport(int id)
        {
            var data = DataAccessFactory.ModeratorData().GetAll(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorSalesReportDTO>();
                c.CreateMap<SalesReport, SalesReportDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ModeratorSalesReportDTO>(data);
            return mapped;

        }

        public static bool Create(ModeratorDTO Moderator)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ModeratorDTO, Moderator>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Moderator>(Moderator);
            var res = DataAccessFactory.ModeratorData().Created(mapped);

            if (res) return true;
            return false;

        }
        public static bool Update(ModeratorDTO Moderator)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ModeratorDTO, Moderator>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Moderator>(Moderator);
            var res = DataAccessFactory.ModeratorData().Update(mapped);

            if (res) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ModeratorData().Delete(id);
        }
    }
}