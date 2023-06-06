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
    public  class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data=DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }

        public static ProductDTO Get(int id) 
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
                

            });

            var mapper = new Mapper(cfg);
            var mapped=mapper.Map<ProductDTO>(data);
            return mapped;
        }

        //find product seller man 
        public static ProductSellerDTO GetwithSeller(int id )
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
               
                c.CreateMap<Product, ProductSellerDTO>();
                c.CreateMap<Seller, SellerDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductSellerDTO>(data);
            return mapped;
        }

        public static bool Create(ProductDTO product)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Product>(product);
            var res = DataAccessFactory.ProductData().Create(mapped);
            if (res)  return true ;
            return false;
        }

        public static bool Update(ProductDTO product)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });

            var mapper = new Mapper(config);
            var mapped = mapper.Map<Product>(product);
            var res = DataAccessFactory.ProductData().Update(mapped);
            if (res) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ProductData().Delete(id);
        }
    }
}
