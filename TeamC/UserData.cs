using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class UserData
    {
        private string password;
        private string emailAddress;
        private string account;
        private int usertype;
        private List<Order> orderlist=new List<Order>();
        private List<string> payinformation;

        public UserData(string id="", string pwd = "", string email = "")
        {
            emailAddress = email;
            password = pwd;
            account = id;
            usertype  = 0;
        }

        public void SetPayinformation(List<string> Payinformation)
        {
            payinformation = Payinformation;
        }
        public List<string> GetPayinformation()
        {
            return payinformation;
        }
        public void SetPassword(string pwd)
        {
            password = pwd;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetUserType(int UserType)
        {
            usertype = UserType;
        }
        public int GetUserType()
        {
            return usertype;
        }
        public void SetOrderList(Order order)
        {
            orderlist.Add(order);
        }
        public void SetEmail(string address)
        {
            if(!address.Equals(string.Empty))
                emailAddress = address;
        }
        public string GetEmail()
        {
            return emailAddress;
        }
        public Order GetOrderList()
        {
            return orderlist[0];
        }

        public string GetAccount()
        {
            return account;
        }
    }
}
