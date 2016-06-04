using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class User
    {
        List<UserData> userDatas;
        UserData currentUser;

        public User()
        {
            userDatas = new List<UserData>();
        }

        public bool IdExist(string id)
        {
            if (GetUserData(id) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public UserData GetUserData(string id)
        {
            foreach (UserData userData in userDatas)
            {
                if (userData.GetAccount().Equals(id))
                {
                    return userData;
                }
            }
            return null;
        }

        public UserData GetUserData(int index)
        {
            if (index < 0 || index >= userDatas.Count)
            {
                return null;
            }
            return userDatas[index];
        }

        // return null when no one login 
        public UserData GetCurrentLoginUser()
        {
            return currentUser;
        }

        public bool Login(string id, string password)
        {
            UserData loginUser = GetUserData(id);
            if (loginUser == null)
            {
                Console.WriteLine("account dose not exist");
                return false;
            }
            else
            {
                if (loginUser.GetPassword().Equals(password)){
                    return true;
                }
                else{
                    Console.WriteLine("account dose not exist");
                    return false;
                }
            }
        }

        public void Logout()
        {
            currentUser = null;
        }

        public void Registered(string id, string password, string email = "")
        {
            if (IdExist(id)){
                Console.WriteLine("account already exist");
                return;
            }
            else{
                UserData newAccount = new UserData(id, password, email);
                userDatas.Add(newAccount);
            }
        }
    }
}
