using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    [TestFixture]
    class ShoppingSystemTest
    {
        [Test]
        public void TestCreateNewAccount()
        {
            ShoppingSystem users = new ShoppingSystem();
            users.Registered("A", "pswA");
            Assert.That(users.GetUserData("A").GetAccount(), Is.EqualTo("A"));
            Assert.That(users.GetUserData("A").GetPassword(), Is.EqualTo("pswA"));
        }
        [Test]
        public void TestGetUserData()
        {
            ShoppingSystem users = new ShoppingSystem();
            users.Registered("A", "pswA");
            // GetUserData(int)
            Assert.That(users.GetUserData(0).GetAccount(), Is.EqualTo("A"));
            Assert.That(users.GetUserData(0).GetPassword(), Is.EqualTo("pswA"));
            Assert.That(users.GetUserData(1), Is.EqualTo(null));
            // GetUserData(string)
            Assert.That(users.GetUserData("A").GetAccount(), Is.EqualTo("A"));
            Assert.That(users.GetUserData("A").GetPassword(), Is.EqualTo("pswA"));
            Assert.That(users.GetUserData("B"), Is.EqualTo(null));
        }

        [Test]
        public void TestLogin()
        {
            ShoppingSystem users = new ShoppingSystem();
            users.Registered("A", "pswA");

            Assert.That(users.Login("A", "pswA"), Is.EqualTo(true));
            Assert.That(users.Login("A", "BBBBB"), Is.EqualTo(false));
            Assert.That(users.Login("B", "BBBBB"), Is.EqualTo(false));
        }
        [Test]
        public void GetProduct()
        {
            ShoppingSystem users = new ShoppingSystem();
            Product product = new Product("Test1", "Expensive", 30000, 1);
            users.InsertProduct(product);
            Assert.That("", Is.EqualTo(users.GetProduct(1).getName()));
        }
        [Test]
        public void InsertProduct()
        {
            ShoppingSystem users = new ShoppingSystem();
            Product product = new Product("Test1", "Expensive", 30000, 1);
            Product product2 = new Product("Test2", "Ex", 300, 2);
            users.InsertProduct(product);
            users.InsertProduct(product2);
            Assert.That("Test1", Is.EqualTo(users.GetProduct(0).getName()));
            Assert.That("Test2", Is.EqualTo(users.GetProduct(1).getName()));
        }
        [Test]
        public void ProductandRemove()
        {
            ShoppingSystem users = new ShoppingSystem();
            Product product = new Product("Test1", "Expensive", 30000, 1);
            Product product2 = new Product("Test2", "Ex", 300, 2);
            users.InsertProduct(product);
            users.InsertProduct(product2);
            Assert.That("Test1", Is.EqualTo(users.GetProduct(0).getName()));
            Assert.That("Test2", Is.EqualTo(users.GetProduct(1).getName()));
            users.RemoveProduct(product2);
            Assert.That("", Is.EqualTo(users.GetProduct(1).getName()));
        }
    }
}

