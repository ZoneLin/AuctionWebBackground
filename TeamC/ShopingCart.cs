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
        List<int> productnum = new List<int>();
        public int InsertProduct(Product product)
        {
            for (int i = 0; i < productlist.Count; i++)
            {
                if (product.getName() == productlist[i].getName()
                    && product.getPrice() == productlist[i].getPrice()
                    && product.getContent() == productlist[i].getContent()
                    )
                {
                    productnum[i]++;
                    return productnum[i];
                }

            }
            productlist.Add(product);
            productnum.Add(1);
            return productnum[productlist.Count - 1];
        }
        public Product GetProduct(int index)
        {
            return productlist[index];
        }
        public int GetProductnum(int index)
        {
            return productnum[index];
        }
    }
}
