
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
        public void TestProductLastTime()
        {
            Product A = new Product();
            Assert.That(DateTime.Now, Is.EqualTo(A.getLastTime()));

        }
        [Test]
        public void TestGetAndSetName()
        {
            Product product = new Product();
            product.SetName("name");
            Assert.That("name", Is.EqualTo(product.getName()));
        }
        [Test]
        public void TestInitProductMethod()
        {
            Product product = new Product("name", "content", 100);
            Assert.That("name", Is.EqualTo(product.getName()));
            Assert.That("content", Is.EqualTo(product.getContent()));
            Assert.That(100, Is.EqualTo(product.getPrice()));

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

        [Test]
        public void TestGetComment()
        {
            DateTime t_date = DateTime.Now;
            Product product = new Product();
            CommentClass comment = new CommentClass();
            comment.setCommentContent("123");

            product.Addcomment(comment);

            comment = new CommentClass();
            comment.setCommentContent("456");
            product.Addcomment(comment);

            CommentClass temp = product.GetComment(0);
           
            Assert.That(temp.getCommentContent(),Is.EqualTo("123"));
        }
        [Test]
        public void TestAddComment()
        {
            Product product = new Product();
            CommentClass comment = new CommentClass();
            comment.setCommentContent("123");
            comment.setCommentDate(DateTime.Now);
            product.Addcomment(comment);

            Assert.That(product.getCommentCount(), Is.EqualTo(1));

        }
        [Test]
        public void TestRemoveComment()
        {
            Product product = new Product();
            CommentClass comment = new CommentClass();
            comment.setCommentContent("123");
            comment.setCommentDate(DateTime.Now);
            product.Addcomment(comment);
            product.Removecomment(0);


            Assert.That(product.getCommentCount(), Is.EqualTo(0));
        }
    }
}