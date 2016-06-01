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
    }
}
