using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Globalization;
namespace TeamC
{
    [TestFixture]
    class CommentClassTest
    {
        [Test]
        public void testGetCommentDate() {
            UserData user= new UserData("test", "pwd", "mail");
            CommentClass comment = new CommentClass("test", user.GetAccount());
            //get Now time
            string nowTime = DateTime.Now.ToString("G", CultureInfo.InvariantCulture);
            Assert.That(nowTime, Is.EqualTo(comment.getCommentDate()));
        }
        [Test]
        public void testGetCommentContent()
        {
            UserData user = new UserData("test", "pwd", "mail");
            //set content
            string content = "I'm comment";
            CommentClass comment = new CommentClass(content, user.GetAccount());
            Assert.That(content, Is.EqualTo(comment.getCommentContent()));
        }
        [Test]
        public void testGetCommentContent()
        {
            UserData user = new UserData("test", "pwd", "mail");
            //set content
            string content = "I'm comment";
            CommentClass comment = new CommentClass(content, user.GetAccount());
            Assert.That(content, Is.EqualTo(comment.getCommentContent()));
        }

    }
}
