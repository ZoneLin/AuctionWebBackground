using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class ShopingCartTest
    {

        [Test]
        public void TestInsertProduct()
        {
            Product product = new Product();
            ShopingCart productlist = new ShopingCart();
            product.SetName("name");
            product.SetContent("content");
            product.SetPrice(100);
            productlist.InsertProduct(product);
            Assert.That("name", Is.EqualTo(productlist.showName(0)));
            Assert.That("content", Is.EqualTo(productlist.showContent(0)));
            Assert.That(100, Is.EqualTo(productlist.showPrice(0)));
        }
        [Test]
        public void TestGetProduct()
        {
            Product product = new Product();
            Product product2 = new Product();
            ShopingCart productlist = new ShopingCart();
            product.SetName("name1");
            product.SetContent("content");
            product.SetPrice(100);
            productlist.InsertProduct(product);
            product2.SetName("name2");
            product2.SetContent("content2");
            product2.SetPrice(200);
            productlist.InsertProduct(product2);
            Assert.That("name1", Is.EqualTo(productlist.GetProduct(0).getName()));
            Assert.That("name2", Is.EqualTo(productlist.GetProduct(1).getName()));
            Assert.That(100, Is.EqualTo(productlist.GetProduct(0).getPrice()));
            Assert.That(200, Is.EqualTo(productlist.GetProduct(1).getPrice()));
        }
    }
}

