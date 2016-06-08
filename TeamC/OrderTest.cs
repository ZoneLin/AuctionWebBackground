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
        /// <summary>
        ///  付款方式
        /// </summary>
        [Test]
        public void Test_SetPaymethod()
        {
            Order order = new Order();

            order.SetPaymethod(0);

            string output = order.GetPayMethod();

            Assert.That(output, Is.EqualTo("信用卡"));
        }

        [Test]
        public void Test_SetPaymethod_1()
        {
            Order order = new Order();

            order.SetPaymethod(1);

            string output = order.GetPayMethod();

            Assert.That(output, Is.EqualTo("匯款"));
        }

        [Test]
        public void Test_SetPaymethod_2()
        {
            Order order = new Order();

            order.SetPaymethod(2);

            string output = order.GetPayMethod();

            Assert.That(output, Is.EqualTo("貨到付款"));
        }

        [Test]
        public void Test_SetPaymethod_3()
        {
            Order order = new Order();

            order.SetPaymethod(3);

            string output = order.GetPayMethod();

            Assert.That(output, Is.EqualTo("請選擇"));
        }
    


        /// <summary>
        /// 訂單狀態
        /// /// </summary>
        [Test]
        public void Test_SetOrderState()
        {
            Order order = new Order();

            order.SetOrderState(0);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo("出貨中"));
        }


        [Test]
        public void Test_SetOrderState1()
        {
            Order order = new Order();

            order.SetOrderState(1);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo("運送中"));
        }


        [Test]
        public void Test_SetOrderState2()
        {
            Order order = new Order();

            order.SetOrderState(2);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo("已到貨"));
        }


        [Test]
        public void Test_SetOrderState3()
        {
            Order order = new Order();

            order.SetOrderState(3);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo("已取貨"));
        }


        [Test]
        public void Test_SetOrderState4()
        {
            Order order = new Order();

            order.SetOrderState(4);

            string output = order.GetOrderState();

            Assert.That(output, Is.EqualTo("未知"));
        }


        /// <summary>
        /// 購買時間
        /// </summary>
        [Test]
        public void Test_SetBuytime()
        {
            Order order = new Order();

            string output = order.GetBuyTime();

            Assert.That(output, Is.EqualTo(output));
        }


        [Test]      //not finish
        public void Test_AddFromCart()
        {
            Order order = new Order();
            ShopingCart cart = new ShopingCart();
            Product product = new Product("apple", "good apple", 999);
            cart.InsertProduct(product);
            order.AddFromCartToOrder(cart);
            Assert.That(product.getName(), Is.EqualTo(order.Getproductlist(0).getName()));
   
        }

    }
}
