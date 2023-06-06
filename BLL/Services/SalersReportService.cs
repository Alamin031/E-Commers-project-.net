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
    public class SalesReportService
    {
        public static List<SalesReportDTO> Get()
        {
            var data = DataAccessFactory.SalesReportData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SalesReport, SalesReportDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SalesReportDTO>>(data);
            return mapped;
        }

        public static SalesReportDTO Get(int id)
        {
            var data = DataAccessFactory.SalesReportData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SalesReport, SalesReportDTO>();


            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SalesReportDTO>(data);
            return mapped;
        }

        public static SalesReportReportedBy GetwithModerator(int id)
        {
            var data = DataAccessFactory.SalesReportData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {

                c.CreateMap<SalesReport, SalesReportReportedBy>();
                c.CreateMap<Moderator, ModeratorDTO>();


            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SalesReportReportedBy>(data);
            return mapped;
        }

        public static bool Create(SalesReportDTO SalesReport)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalesReportDTO, SalesReport>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalesReport>(SalesReport);
            var res = DataAccessFactory.SalesReportData().Create(mapped);
            if (res) return true;
            return false;
        }

        public static bool Update(SalesReportDTO SalesReport)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalesReportDTO, SalesReport>();
            });

            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalesReport>(SalesReport);
            var res = DataAccessFactory.SalesReportData().Update(mapped);
            if (res) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.SalesReportData().Delete(id);
        }
        public static List<SalesReportDTO> SearchSalesReport(SearchModelDTO search)
        {

            var sales = DataAccessFactory.SalesReportSearch().Search(search.Search);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SalesReport, SalesReportDTO>());
            var mapper = new Mapper(config);
            var salesReports = mapper.Map<List<SalesReportDTO>>(sales);

            return salesReports;

        }
    }
}