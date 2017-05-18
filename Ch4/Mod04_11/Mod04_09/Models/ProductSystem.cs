using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod04_09.DAL;
using Mod04_09.ViewModels;

namespace Mod04_09.Models
{
    public class ProductSystem
    {
        public ProductViewModel GetProductByID(int id)
        {
            //撰寫商業邏輯的地方
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id                        
                        select new ProductViewModel { ProductID = p.ProductID,
                                                      ProductName = p.ProductName,
                                                      UnitPrice = p.UnitPrice };//LINQ語法：new 新的物件同時將值塞入欄位。
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