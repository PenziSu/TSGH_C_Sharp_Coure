using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_09.ViewModels
{
    public class CategoryProductsViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
