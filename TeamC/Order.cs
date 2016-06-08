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

        enum paymethodType { 請選擇, 信用卡, 匯款, 貨到付款 };
        enum orderstateType { 未知, 出貨中, 運送中, 已到貨, 已取貨 };
        paymethodType paymethod;
        orderstateType orderstate;
        private DateTime buytime;

        public void SetPaymethod(int methodCode)
        {
            switch(methodCode)
            {
                case 0:
                    paymethod = paymethodType.信用卡;
                    break;
                case 1:
                    paymethod = paymethodType.匯款;
                    break;
                case 2:
                    paymethod = paymethodType.貨到付款;
                    break;
                default:
                    paymethod = paymethodType.請選擇;
                    break;
            }
        }
        public void SetOrderState(int stateCode)
        {
            switch (stateCode)
            {
                case 0:
                    orderstate = orderstateType.出貨中;
                    break;
                case 1:
                    orderstate = orderstateType.運送中;
                    break;
                case 2:
                    orderstate = orderstateType.已到貨;
                    break;
                case 3:
                    orderstate = orderstateType.已取貨;
                    break;
                default:
                    orderstate = orderstateType.未知;
                    break;
            }
        }
        
        public void SetBuyTime(DateTime time)
        {

            buytime = time;
        }

        public string GetOrderState()
        {
            return orderstate.ToString();
        }
        
        public void AddFromCartToOrder(ShopingCart cart)
        {  // add products into the order list from the shoppping cart
            int counter = cart.GetCount();      //get the nubmer of product in cart
            for (int i = 0; i < counter; i++)
            {
                productlist.Add(cart.GetProduct(i));
            }
        }

        //////////////////////////////////////////////////////

        public Product Getproductlist(int indext)
        {
            return productlist[indext];
        }

        public string GetBuyTime()
        {
            return buytime.ToString();
        }

        public string GetPayMethod()
        {
            return paymethod.ToString();
        }
    }
}
