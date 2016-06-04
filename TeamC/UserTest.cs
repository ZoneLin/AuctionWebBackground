using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class UserTest
    {
        [Test]
        public void TestCreateNewAccount()
        {
            User users = new User();
            users.Registered("A", "pswA");
            Assert.That(users.GetUserData("A").GetAccount(), Is.EqualTo("A"));
            Assert.That(users.GetUserData("A").GetPassword(), Is.EqualTo("pswA"));
        }

        [Test]
        public void TestGetUserData()
        {
            User users = new User();
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
        public void TestAccountIsExist()
        {
            User users = new User();
            Assert.That(users.IdExist("A"), Is.EqualTo(false));
            users.Registered("A", "pswA");
            Assert.That(users.IdExist("A"), Is.EqualTo(true));
        }

        [Test]
        public void TestLogin()
        {
            User users = new User();
            users.Registered("A", "pswA");

            Assert.That(users.Login("A", "pswA"), Is.EqualTo(true));
            Assert.That(users.Login("A", "BBBBB"), Is.EqualTo(false));
            Assert.That(users.Login("B", "BBBBB"), Is.EqualTo(false));
        }

        [Test]
        public void TestCurrentUser()
        {
            User users = new User();
            users.Registered("A", "pswA");
            users.Login("A", "pswA");

            Assert.That(users.GetCurrentLoginUser(), Is.EqualTo(users.GetUserData("A")));
            users.Logout();
            Assert.That(users.GetCurrentLoginUser(), Is.EqualTo(null));
        }
    }
}
