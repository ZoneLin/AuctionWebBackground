using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class ProductTest
    {
        [Test]
        public void TestGetAndSetName() {
            Product product = new Product();
            product.SetName("name");
            Assert.That("name", Is.EqualTo(product.getName()));
        }
        [Test]
        public void TestGetAndSetContent()
        {
            Product product = new Product();
            product.SetContent("content");
            Assert.That("content", Is.EqualTo(product.getContent()));
        }
        [Test]
        public void TestGetAndSetPrice()
        {
            Product product = new Product();
            product.SetPrice(100);
            Assert.That(100, Is.EqualTo(product.getPrice()));
        }

    }
}
