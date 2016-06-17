using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace TeamC
{
    [TestFixture]
    class CommentTest
    {
        [Test]
        public void Test_initAndGetcomment()
        {
            Comment comment = new Comment("nice");
            Assert.That(comment.Getcomment(), Is.EqualTo("nice"));
        }
        [Test]
        public void Test_SetAndGetcomment()
        {
            Comment comment = new Comment("nice");
            comment.Setcomment("bad");
            Assert.That(comment.Getcomment(), Is.EqualTo("bad"));
        }
    }
}
