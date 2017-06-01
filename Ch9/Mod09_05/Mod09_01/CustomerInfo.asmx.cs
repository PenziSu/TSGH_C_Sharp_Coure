using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mod09_01
{
    /// <summary>
    /// Summary description for CustomerInfo
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService] //<<=重點, 註解解開後就可以回傳其他格式, 如Json
    public class CustomerInfo : System.Web.Services.WebService
    {

        [WebMethod]
        public Customer GetCustomer(string id)
        {
            //假造查詢資料庫的範例資料
            List<Customer> data = new List<Customer>
            {
                new Customer {CustomerId="123",Name="Mary" },
                new Customer {CustomerId="223",Name="Candy" },
                new Customer {CustomerId="323",Name="Peter" }
            };
            Customer customer = data.Find(c => c.CustomerId == id);
            return customer;
        }
    }

    public  class Customer
    {
        public string CustomerId {
            get; set;
        }
        public string Name { get; set; }
    }
}
