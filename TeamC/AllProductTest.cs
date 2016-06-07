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
            Product product = new Product("Test1", "Expensive", 30000,1);
            Product product2 = new Product("Test2", "Cheap", 100,1);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            Assert.That("Test2", Is.EqualTo(allproduct.GetProduct(1).getName()));
        }
        [Test]
        public void TestGetProductExcept()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product("Test1", "Expensive", 30000,1);
            allproduct.InsertProduct(product);
            Assert.That("", Is.EqualTo(allproduct.GetProduct(1).getName()));
        }
        [Test]
        public void TestInsertAndRemove()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product("Test1", "Expensive", 30000,1);
            Product product2 = new Product("Test2", "Cheap", 100,1);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            allproduct.RemoveProduct(product);
            Assert.That("Test2", Is.EqualTo(allproduct.GetProduct(0).getName()));
        }
        [Test]
        public void TestGetIndex()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product("Test1", "Expensive", 30000,1);
            Product product2 = new Product("Test2", "Cheap", 100,1);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            Assert.That(1, Is.EqualTo(allproduct.GetProductIndex(product2)));
        }
        [Test]
        public void TestAutoRemove()
        {
            AllProduct allproduct = new AllProduct();
            Product product = new Product("Test1", "Expensive", 30000, 1);
            Product product2 = new Product("Test2", "Cheap", 100, 1);
            allproduct.InsertProduct(product);
            allproduct.InsertProduct(product2);
            allproduct.GetProduct(0).setNum(0);
            allproduct.CheckRemove();
            Assert.That(0, Is.EqualTo(allproduct.GetProductIndex(product2)));
        }
        [Test]
        public void TestSearching() {
            AllProduct allproduct = new AllProduct();
            for (int i = 0; i <= 5; i++) {
                Product p = new Product("" + i, i + "5", 20);
                allproduct.InsertProduct(p);
            }
            // (index)name content price
            //           0      05    20
            //           1      15    20
            //           2      25    20
            //           3      35    20
            //           4      45    20
            //           5      55    20
            List<Product> result = new List<Product>();
            result.Add(allproduct.GetProduct(1));
            Assert.That(result, Is.EqualTo(allproduct.search("1")));
            //moreDifficult
            result.Clear();
            result.Add(allproduct.GetProduct(0));
            result.Add(allproduct.GetProduct(1));
            result.Add(allproduct.GetProduct(2));
            result.Add(allproduct.GetProduct(3));
            result.Add(allproduct.GetProduct(4));
            result.Add(allproduct.GetProduct(5));
            Assert.That(result, Is.EqualTo(allproduct.search("2")));
            //and more
            Assert.That(result, Is.EqualTo(allproduct.search("5")));

        }
    }
}
