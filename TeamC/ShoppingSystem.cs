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

        public void Registered(string id, string password)
        {
            user.Registered(id, password);
        }
        public Boolean Login(string id, string password)
        {
            Boolean flag = user.Login(id, password);
            return flag;
        }
        public void Logout()
        {
            user.Logout();
        }
        public UserData GetUserData(string id)
        {
            UserData userdata = user.GetUserData(id);
            return userdata;
        }
        public UserData GetUserData(int index)
        {
            UserData userdata = user.GetUserData(index);
            return userdata;
        }
        public UserData GetCurrentLoginUser(string id)
        {
            UserData userdata = user.GetUserData(id);
            return userdata;
        }
        public Product GetProduct(int index)
        {
            Product Getproduct = allproduct.GetProduct(index);
            return Getproduct;
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

        public void RemoveProduct(Product product)
        {
            allproduct.RemoveProduct(product);
        }
    }
}
