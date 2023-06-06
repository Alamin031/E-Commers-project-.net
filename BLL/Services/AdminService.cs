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
    public class ManageAdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().GetAll();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }
        public static AdminModeratorDTO GetAdminAddedModerators(int id)
        {
            var data = DataAccessFactory.AdminData().GetAll(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModeratorDTO>();
                c.CreateMap<Moderator, ModeratorDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminModeratorDTO>(data);
            return mapped;

        }

        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminData().GetAll(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }
        public static bool Create(AdminDTO Admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Created(mapped);

            if (res) return true;
            return false;

        }
        public static bool Update(AdminDTO Admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Update(mapped);

            if (res) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }
    }
}

