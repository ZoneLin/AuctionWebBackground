using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class AllProductTest
    {
        [Test]
        public void TestInsertAndGet()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product();
            product.SetName("Test1");
            product.SetContent("Very Expensive");
            product.SetPrice(300000);
            Product product2 = new Product();
            product2.SetName("Test2");
            product2.SetContent("Very cheap");
            product2.SetPrice(10);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            Assert.That("Test2", Is.EqualTo(allproduct.GetProduct(1).getName()));
        }
        [Test]
        public void TestInsertAndRemove()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product();
            product.SetName("Test1");
            product.SetContent("Very Expensive");
            product.SetPrice(300000);
            Product product2 = new Product();
            product2.SetName("Test2");
            product2.SetContent("Very cheap");
            product2.SetPrice(10);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            allproduct.RemoveProduct(product);
            Assert.That("Test2", Is.EqualTo(allproduct.GetProduct(0).getName()));
        }
        [Test]
        public void TestGetIndex()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product();
            product.SetName("Test1");
            product.SetContent("Very Expensive");
            product.SetPrice(300000);
            Product product2 = new Product();
            product2.SetName("Test2");
            product2.SetContent("Very cheap");
            product2.SetPrice(10);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            Assert.That(1, Is.EqualTo(allproduct.GetProductIndex(product2)));
        }
    }
}
