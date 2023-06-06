using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{


    internal class SalesReportRepo : Repo, IRepo<SalesReport, int, bool>,ISearch<SalesReport>
    {
        public bool Create(SalesReport obj)
        {
            db.SalesReports.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.SalesReports.Remove(ex);
            return db.SaveChanges() > 0;
        }
        //SORT

        //public List<SalesReport> GetTop()
        //{
        //    var list =(from x in db.SalesReports
        //               where x.MonthName.Equals("january")
        //               select x).ToList();
        //    return list ;
            
        //}

        public List<SalesReport> Read()
        {
            return db.SalesReports.ToList();
        }

        public SalesReport Read(int id)
        {
            return db.SalesReports.Find(id);
        }

        public List<SalesReport> Search(Dictionary<string, dynamic> search)
        {
            if (search.Count == 1)
            {
                string key = Convert.ToString(search.ElementAt(0).Key);
                string value = Convert.ToString(search.ElementAt(0).Value);

                var list = new List<SalesReport>();


                if (key == "Name")
                {
                    list = (from c in db.SalesReports
                            where c.MonthName.Equals(value)
                            select c).ToList();
                }
                else if (key == "ReportedBy")
                {
                    list = (from c in db.SalesReports
                            where c.ReportedBy.ToString().Equals(value)
                            select c).ToList();
                }

                return list;

            }
            else if (search.Count == 2)
            {
                string key1 = Convert.ToString(search.ElementAt(0).Key);
                string value1 = Convert.ToString(search.ElementAt(0).Value);
                string key2 = Convert.ToString(search.ElementAt(1).Key);
                string value2 = Convert.ToString(search.ElementAt(1).Value);

                var list = new List<SalesReport>();
                if (key1 == "Name" && key2 == "ReportedBy")
                {
                    list = (from c in db.SalesReports
                            where c.MonthName.Equals(value1) &&
                            c.ReportedBy.ToString().Equals(value2)
                            select c).ToList();
                }
               
                return list;
            }
            else
                return null;
           
      
        }

        public bool Update(SalesReport Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}

