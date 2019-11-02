using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class SuperShop
    {
        public string Name { get; set; }
        public string Address { get; set; }

        private List<Product> products;

        public SuperShop()
        {
            products = new List<Product>();
        }
        public bool AddProduct(Product product)
        {
            if (products.Count > 0)
            {
                foreach (Product aProduct in products)
                {
                    if (aProduct.Product_id == product.Product_id)
                    {
                        aProduct.Quantity += product.Quantity;
                        return true;
                    }  
                }
            }
           products.Add(product);
           return true;
        }

        public string GetProducts()
        {
            string message = "";
            string shopinfo = "Name : " + Name + " Address : " + Address;
            string header = "Product ID \t\t\t Quantity";
            string productinfo = "";
            foreach (Product product in products)
            {
                productinfo += product.Product_id + "\t\t\t" + product.Quantity+"\n";
            }
            message = shopinfo + "\n" + header +"\n" + productinfo;
            return message;
        }

    }
}
