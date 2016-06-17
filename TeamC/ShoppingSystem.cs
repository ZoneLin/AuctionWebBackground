using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class ShoppingSystem
    {
        private Order order = new Order();
        private AllProduct allproduct = new AllProduct();
        private User user = new User();

        public bool Registered(string id, string password)
        {
            if (user.Registered(id, password)== "Registered Succeed")
                return true;
            return false;
        }
        public Boolean Login(string id, string password)
        {
            Boolean flag = user.Login(id, password);
            return flag;
        }
        public bool Logout()
        {
            if (user.Logout() == "Logout Succeed")
                return true;
            return false;
        }
        public UserData GetUserData(string id)
        {
            UserData userdata = user.GetUserData(id);
            if(userdata!=null)
                return userdata;
            return null;
        }
        public UserData GetUserData(int index)
        {
            UserData userdata = user.GetUserData(index);
            if (userdata != null)
                return userdata;
            return null;
        }
        public UserData GetCurrentLoginUser(string id)
        {
            UserData userdata = user.GetUserData(id);
            if (userdata != null)
                return userdata;
            return null;
        }
        public Product GetProduct(int index)
        {
            Product Getproduct = allproduct.GetProduct(index);
            if (Getproduct != null)
                return Getproduct;
            return null;
        }
        public void InsertProduct(Product product)
        {
            allproduct.InsertProduct(product);
        }
        public void RemoveProduct(Product product)
        {
            allproduct.RemoveProduct(product);
        }
        public void CheckRemove()
        {
            allproduct.CheckRemove();
        }

       
    }
}
