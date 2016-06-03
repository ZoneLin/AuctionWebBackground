using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class OrderTest
    {
        [Test]
        public void Test_SetPaymethod(string input_order_method)
        {
            Order order = new Order();

            input_order_method = "貨到付款";

            order.SetPaymethod(input_order_method);

            string output = order.GetPayMethod();

            Assert.That(output, Is.EqualTo(input_order_method));

        }
    
        [Test]
        public void Test_SetOrderState(string input_order_state)
        {
            Order order = new Order();

            input_order_state = "出貨中";

            order.SetOrderState(input_order_state);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo(input_order_state));
        }


        [Test]
        public void Test_SetBuytime(string input_order_buytime)
        {
            Order order = new Order();

            input_order_buytime = "12:30";

            string output = order.GetBuyTime();

            Assert.That(output, Is.EqualTo(input_order_buytime));
        }


    }
}
