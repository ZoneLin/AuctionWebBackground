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
        private string request;
        private int usertype;
        private List<ShopingCart> shopchart = new List<ShopingCart>();
        private List<Order> orderlist=new List<Order>();
        private List<string> payinformation;
        private string evaluate;
        public UserData(string id="", string pwd = "", string email = "")
        {
            emailAddress = email;
            password = pwd;
            account = id;
            usertype  = 0;
            request = null;
            evaluate = null;
        }

        public bool SetPayinformation(List<string> Payinformation)
        {
            if (Payinformation != null)
            {
                payinformation = Payinformation;
                return true;
            }
                return false;
        }
        public List<string> GetPayinformation()
        {
                return payinformation;

        }
        public int SetPassword(string pwd)
        {
            int j;
            if (Int32.TryParse(pwd, out j))
                return 0;
            else
                password = pwd;
            return 1;
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
        public int SetEmail(string address)
        {
            int truth = 0;
            char[] EmailAddress = address.ToCharArray();
            for (int i = 0; i < EmailAddress.Length; i++)
            {
                if (EmailAddress[i] == '@')
                    truth += 1;
                else if (EmailAddress[i] == '.' && i == (EmailAddress.Length - 4))
                    if (EmailAddress[i + 1] == 'c')
                        if (EmailAddress[i + 2] == 'o')
                            if (EmailAddress[i + 3] == 'm')
                                truth += 1;
            }
            if (truth == 2)
                emailAddress = address;
            return truth;
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
        public void Setshopcart(ShopingCart shp)
        {
            shopchart.Add(shp);
        }
        public ShopingCart Getshopcart()
        {
            return shopchart[0];
        }
        public string Getrequest()
        {
            return request;
        }
        public void Setrequest(string input)
        {
            request=input;
        }
        public void Setevaluate(string evaluate_input)
        {
            if(usertype==1)
                evaluate = evaluate_input;
        }
        public string Getevaluate()
        {
            if (usertype == 1)
                return evaluate;
            else
                return "Not Seller";
        }
    }
}
