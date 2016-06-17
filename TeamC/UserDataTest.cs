using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class UserDataTest
    {
        [Test]
        public void TestSetandGetPayinformation()
        {
            UserData user = new UserData();
            List<string> Payinformation=new List<string>();
            Payinformation.Add("12345678");
            user.SetPayinformation(Payinformation);
            Assert.That(Payinformation, Is.EqualTo(user.GetPayinformation()));
        }
        [Test]
        public void TestSetandGetPassword()
        {
            UserData user = new UserData();
            string passwd = "12345678";
            Assert.That(0, Is.EqualTo(user.SetPassword(passwd)));
            string passwd2 = "sy12345678";
            Assert.That(1, Is.EqualTo(user.SetPassword(passwd2)));
            Assert.That(passwd2, Is.EqualTo(user.GetPassword()));

        }
        [Test]
        public void TestSetandGetUsertype()
        {
            UserData user = new UserData();
            int UserType = 1;
            user.SetUserType(UserType);
            Assert.That(UserType, Is.EqualTo(user.GetUserType()));

        }
        [Test]
        public void TestSetGetOrderList()
        {
            UserData user = new UserData();
            Order ord=new Order();
            user.SetOrderList(ord);
            Assert.That(ord, Is.EqualTo(user.GetOrderList()));

        }
        [Test]
        public void TestSetGetEmail()
        {
            UserData user = new UserData();
            string addr = "123";
            Assert.That(0, Is.EqualTo(user.SetEmail(addr)));
            addr = "12425@gmail";
            Assert.That(1, Is.EqualTo(user.SetEmail(addr)));
            addr = "12425@gmail.com";
            Assert.That(2, Is.EqualTo(user.SetEmail(addr)));
            addr = "12425@gmail.com";
            Assert.That(addr, Is.EqualTo(user.GetEmail()));

        }
        [Test]
        public void TestSetGetshopcart()
        {
            UserData user = new UserData();
            ShopingCart ord = new ShopingCart();
            user.Setshopcart(ord);
            Assert.That(ord, Is.EqualTo(user.Getshopcart()));
        }
        [Test]
        public void TestSetGetevaluate()
        {
            UserData user = new UserData();
            user.SetUserType(1);
            user.Setevaluate("nice");
            Assert.That(user.Getevaluate(), Is.EqualTo("nice"));
        }
        [Test]
        public void TestSetGetevaluateExcept()
        {
            UserData user = new UserData();
            user.SetUserType(0);
            user.Setevaluate("nice");
            Assert.That(user.Getevaluate(), Is.EqualTo("Not Seller"));
        }
    }
}
