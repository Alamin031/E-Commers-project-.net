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
    public class Delivery_Location_Msg_Service
    {
        public static List<Delivery_Location_MsgDTO> Get()
        {
            var data = DataAccessFactory.Delivery_Location_MsgData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Delivery_Location_Msg, Delivery_Location_MsgDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<Delivery_Location_MsgDTO>>(data);
            return mapped;
        }

        public static Delivery_Location_MsgDTO Get(int Id)
        {
            var data = DataAccessFactory.Delivery_Location_MsgData().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Delivery_Location_Msg, Delivery_Location_MsgDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Delivery_Location_MsgDTO>(data);
            return mapped;
        }

        public static bool Create(Delivery_Location_MsgDTO Delivery_Location_Msgs)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Delivery_Location_MsgDTO, Delivery_Location_Msg>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Delivery_Location_Msg>(Delivery_Location_Msgs);
            var res = DataAccessFactory.Delivery_Location_MsgData().Create(mapped);
            if (res) return true;
            return false;
        }
        public static bool Update(Delivery_Location_MsgDTO msg)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Delivery_Location_MsgDTO, Delivery_Location_Msg>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Delivery_Location_Msg>(msg);
            var res = DataAccessFactory.Delivery_Location_MsgData().Update(mapped);
            if (res) return true;
            return false;
        }

        public static bool Delete(int Id)
        {
            return DataAccessFactory.Delivery_Location_MsgData().Delete(Id);
        }
    }
}
