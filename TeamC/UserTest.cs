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
        {   // Registered
            User users = new User();
            // First case : create a new account and make sure it's succeed.
            Assert.That(users.Registered("A", "pswA"), Is.EqualTo("Registered Succeed."));
            users.Registered("A", "pswA");
            Assert.That(users.GetUserData("A").GetAccount(), Is.EqualTo("A"));
            Assert.That(users.GetUserData("A").GetPassword(), Is.EqualTo("pswA"));
            // Second case : there is already an account named "id"
            Assert.That(users.Registered("A", "pswA"), Is.EqualTo("account already exist"));
        }

        [Test]
        public void TestIdExist()
        {
            User users = new User();
            // First case : no such account.
            Assert.That(users.IdExist("A"), Is.EqualTo(false));
            // Second case : id exist !!.
            users.Registered("A", "pswA");
            Assert.That(users.IdExist("A"), Is.EqualTo(true));

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
            // First case : no input id
            Assert.That(users.IdExist(""),Is.EqualTo(false));
            // Second case : no this id in userdatas.
            Assert.That(users.IdExist("A"), Is.EqualTo(false));
            // Third case : There is the user.
            users.Registered("A", "pswA");
            Assert.That(users.IdExist("A"), Is.EqualTo(true));
        }

        [Test]
        public void TestLogin()
        {
            User users = new User();
            users.Registered("A", "pswA");
            // First case : right id and right password.
            Assert.That(users.Login("A", "pswA"), Is.EqualTo(true));
            // Second case : right id but wrong password.
            Assert.That(users.Login("A", "BBBBB"), Is.EqualTo(false));
            // Third case : no this user account.
            Assert.That(users.Login("B", "BBBBB"), Is.EqualTo(false));
        }

        [Test]
        public void TestLogout() {
            User users = new User();
            users.Registered("Bob", "bob123456");
            users.Login("bob", "bob123456");
            Assert.That(users.Logout(), Is.EqualTo("Logout Succeed."));
            users.Logout();
            Assert.That(users.GetCurrentLoginUser(),Is.EqualTo(null));
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

        [Test]
        public void TestResetPassword()
        {
            User users = new User();
            users.Registered("Amy", "amy1234", "amy@gmail.com");
            users.Registered("Sam", "Sam1234", "sam@gmail.com");
            users.Registered("Bob", "bob1234", "bob@gmail.com");
            // First case : No account
            Assert.That(users.ResetPassword("Tom","123456"), Is.EqualTo("Account not exsit !!"));
            // Second case : The same password
            Assert.That(users.ResetPassword("Amy", "amy1234"), Is.EqualTo("Password can't be the same as the previous password !!"));
            // Third case : Succeed
            Assert.That(users.ResetPassword("Bob", "12341234"), Is.EqualTo("Reset scceed !!"));
                       
        }

        [Test]
        public void TestAddRequest()
        {
            User users = new User();
            users.Registered("Amy", "amy1234", "amy@gmail.com");
            users.Registered("Sam", "Sam1234", "sam@gmail.com");
            users.Registered("Bob", "bob1234", "bob@gmail.com");
            users.GetUserData("Amy").SetUserType(0);
            users.GetUserData("Sam").SetUserType(1);
            users.GetUserData("Bob").SetUserType(2);
            users.Request(users.GetUserData("Amy"),"I want to sell");
            users.Request(users.GetUserData("Sam"), "I want to sell");
            // First case : No account
            Assert.That(users.GetUserData("Amy").Getrequest(), Is.EqualTo("I want to sell")); 
        }
        [Test]
        public void TestErrorRequest()
        {
            User users = new User();
            users.Registered("Amy", "amy1234", "amy@gmail.com");
            users.Registered("Sam", "Sam1234", "sam@gmail.com");
            users.Registered("Bob", "bob1234", "bob@gmail.com");
            users.GetUserData("Amy").SetUserType(0);
            users.GetUserData("Sam").SetUserType(1);
            users.GetUserData("Bob").SetUserType(2);
            string result, result2;
            result=users.Request(users.GetUserData("Sam"), "I want to sell");
            result2=users.Request(users.GetUserData("Bob"), "I want to sell");
            
            Assert.That(result, Is.EqualTo("You are a seller or admin."));
            Assert.That(result2, Is.EqualTo("You are a seller or admin."));
        }
        [Test]
        public void TestListCheckRequest()
        {
            User users = new User();
            users.Registered("Amy", "amy1234", "amy@gmail.com");
            users.Registered("Sam", "Sam1234", "sam@gmail.com");
            users.Registered("Bob", "bob1234", "bob@gmail.com");
            users.GetUserData("Amy").SetUserType(0);
            users.GetUserData("Sam").SetUserType(1);
            users.GetUserData("Bob").SetUserType(2);
            users.Request(users.GetUserData("Amy"), "I want to sell");     
            
            Assert.That(users.ListRequest(users.GetUserData("Bob")), Is.EqualTo("0,Amy,I want to sell\n"));
            users.CheckRequest(users.GetUserData("Bob"), 0);
            Assert.That(users.ListRequest(users.GetUserData("Bob")), Is.EqualTo(""));
        }
    }
}
