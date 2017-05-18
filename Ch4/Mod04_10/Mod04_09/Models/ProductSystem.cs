using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod04_09.DAL;

namespace Mod04_09.Models
{
    public class ProductSystem
    {
        public Product GetProductByID(int id)
        {
            //撰寫商業邏輯的地方
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;
            var result = query.First();
            return result;
        }

        public IEnumerable<Product> GetproductsByCategoryID(int id)
        {
            //撰寫商業邏輯的地方
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;
            var result = query.ToList();
            return result;
        }
    }
}