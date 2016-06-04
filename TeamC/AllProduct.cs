using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class AllProduct
    {
        private List<Product> productlist;

        public AllProduct() {
            productlist = new List<Product>();
        }

        public Product GetProduct(int index)
        {
            if (index >= productlist.Count || index < 0)
                return new Product();
            return productlist[index];
        }

        public void InsertProduct(Product product){
            productlist.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            productlist.Remove(product);
        }
        public void CheckRemove()
        {
            for (int i = 0; i < productlist.Count; i++)
            {
                if (productlist[i].getNum() == 0)
                {
                    productlist.Remove(productlist[i]);
                }
            }
        }
        public int GetProductIndex(Product product)
        {
            return productlist.IndexOf(product);
        }
    }
}
