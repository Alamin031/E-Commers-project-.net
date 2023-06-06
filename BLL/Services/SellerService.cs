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
    public  class SellerService
    {
        public static List<SellerDTO> Get()
        {
            var data = DataAccessFactory.SellerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Seller, SellerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SellerDTO>>(data);
            return mapped;
        }

        public static SellerDTO Get(string Sname)
        {
            var data = DataAccessFactory.SellerData().Read(Sname);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Seller, SellerDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SellerDTO>(data);
            return mapped;
        }


        public static bool Create(SellerDTO seller)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SellerDTO, Seller>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Seller>(seller);
            var res = DataAccessFactory.SellerData().Create(mapped);
            if (res) return true;
            return false;
        }

        public static bool Update(SellerDTO seller)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SellerDTO, Seller>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Seller>(seller);
            var res = DataAccessFactory.SellerData().Update(mapped);
            if (res) return true;
            return false;
        }
        public static bool Delete(string Sname)
        {
            return DataAccessFactory.SellerData().Delete(Sname);
        }
        public static bool ChangePassword(string Sname, ChangePasswordDTO changePasswordDTO)
        {
            var seller = DataAccessFactory.SellerData().Read(Sname);
            if (changePasswordDTO.CurrentPassword == seller.Password)
            {
                return DataAccessFactory.ChangePassData().ChangePassword(seller.Sname, changePasswordDTO.Password);
            }
            return false;
        }
    }
}
