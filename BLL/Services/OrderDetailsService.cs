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
    public class OrderDetailsService
    {
        public static List<OrderDetailsDTO> Get()
        {
            var data = DataAccessFactory.OrderDetailsData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDetailsDTO>>(data);
            return mapped;
        }

        public static OrderDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDetailsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetailsDTO>(data);
            return mapped;
        }
       
        public static bool Create(OrderDetailsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetails>(order);
            var res = DataAccessFactory.OrderDetailsData().Create(mapped);
            if (res) return true;
            return false;
        }
        public static bool Update(OrderDetailsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetails>(order);
            var res = DataAccessFactory.OrderDetailsData().Update(mapped);
            if (res) return true;
            return false;
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderDetailsData().Delete(id);
        }
        public static List<ProductDTO> GetTop()
        {
            var list =DataAccessFactory.TopSellingReport().GetTop();
            Dictionary<int,int> calculation = new Dictionary<int,int>();
            foreach (var cal in list)
            {
                int key = cal.ProductId;
                if(calculation.ContainsKey(key))
                {
                    calculation[key]+=cal.Quantity;
                }
                else
                {
                    calculation.Add(key, cal.Quantity);
                }
            }
            List<Product>topProducts = new List<Product>();
            int check = 0;
            foreach (var item in calculation.OrderByDescending(key => key.Value)) 
            {
                int x =item.Key;
                var b=DataAccessFactory.ProductData().Read(x);

                topProducts.Add(b);
                check++;

                if(check == 5) 
                {
                    break;
                }
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>());
            var mapper = new Mapper(config);
            var topProductDTO =mapper.Map<List<ProductDTO>>(topProducts);

            return topProductDTO;
        }

    }
}
    

