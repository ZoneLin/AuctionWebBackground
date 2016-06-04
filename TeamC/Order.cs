using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class Order
    {
        List<Product> productlist = new List<Product>();

        private string buytime = "";
        private string paymethod = "";
        private string orderstate = "";

        public void SetPaymethod(string method)
        {
            paymethod = method;
        }
        public void SetOrderState(string state)
        {
            orderstate = state;
        }
        
        public void SetBuyTime(string time)
        {
            buytime = time;
        }

        public string GetOrderState()
        {
            return orderstate;
        }

        //////////////////////////////////////////////////////

        public Product Getproductlist(int indext)
        {
            return productlist[indext];
        }

        public string GetBuyTime()
        {
            return "12:30";
        }

        public string GetPayMethod()
        {
            return paymethod;
        }
    }
}
