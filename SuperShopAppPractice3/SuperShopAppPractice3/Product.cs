using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Product
    {
        //List<int> Product_id = new List<int>();

        //List<double> Quantity = new List<double>();
        public int Product_id { get; set; }
        public double Quantity { get; set; }
        
        public Product(int id, double quantity)
        {
            this.Product_id = id;
            this.Quantity = quantity;
        }
        public Product()
        {

        }
    }
}
