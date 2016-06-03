using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TeamC
{

    class ShopingCart
    {
        List<Product> productlist = new List<Product>();
        public void InsertProduct(Product product)
        {
            productlist.Add(product);
        }
        public string showName(int index)
        {
            string x = productlist[index].getName();
            return x;
        }
        public string showContent(int index)
        {
            string x = productlist[index].getContent();
            return x;
        }
        public int showPrice(int index)
        {
            int x = productlist[index].getPrice();
            return x;
        }
        public Product GetProduct(int index)
        {
            return productlist[index];
        }
    }
}
