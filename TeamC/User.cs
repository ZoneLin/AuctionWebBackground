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

        public bool Login(string id, string password)
        {
            UserData loginUser = GetUserData(id);
            if (loginUser == null)
                return false;
            else
            {
                if (loginUser.GetPassword().Equals(password))
                    return true;
                else
                    return false;
            }
        }

        public void Registered(string id, string password)
        {

            if (IdExist(id))
                return;
            else
            {
                UserData newAccount = new UserData(id, password);
                userDatas.Add(newAccount);
            }
        }
    }
}
