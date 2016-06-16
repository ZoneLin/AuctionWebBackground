using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
            {   // if id is null, of course dosen't exist.
                return false;
            }
            else
            {   // if found the id in userdatas, return true.
                for (int i = 0; i < userDatas.Count();i++ )
                    if(userDatas[i].GetAccount() == id)
                        return true;
                return false;
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
            {   // no this user id.
                Console.WriteLine("account dose not exist");
                return false;
            }
            else
            {   // right id an right password.
                if (loginUser.GetPassword().Equals(password)){
                    currentUser = GetUserData(id);
                    return true;
                }
                else{   // right id but wrong password.
                    Console.WriteLine("Wrong Password");
                    return false;
                }
            }
        }

        public string Logout()
        {
            currentUser = null;
            return "Logout Succeed.";
        }

        public string Registered(string id, string password, string email = "")
        {
            if (IdExist(id)){
                return "account already exist";
            }
            else{
                UserData newAccount = new UserData(id, password, email);
                userDatas.Add(newAccount);
                return "Registered Succeed.";
            }
        }

        public string ResetPassword(string id , string password)
        {
            for (int i = 0; i < userDatas.Count; i++)
            {
                if (userDatas[i].GetAccount() == id)
                {   // if we find the account
                    if (userDatas[i].GetPassword() == password)
                    {   // if the reset password is the same as the previous one.
                        return "Password can't be the same as the previous password !!";
                    }
                    userDatas[i].SetPassword(password);     // id meets, password-check passes.
                    return "Reset scceed !!" ;
                }
            } 
            return "Account not exsit !!";  // if there is no the specific id.
        }

        public string Request(UserData userdata,string request)
        {
            if (userdata.GetUserType() == 0)
            {
                userdata.Setrequest(request);
                return "Success";
            }
            else
            {
                return "You are a seller or admin.";
            }
        }

        public string ListRequest(UserData userdata) {
            if (userdata.GetUserType() == 2)
            {
                string output="";
                for (int i = 0; i < userDatas.Count; i++)
                {
                    if (userDatas[i].Getrequest() != null)
                    {
                        output += i.ToString()+"," + userDatas[i].GetAccount() + "," + userDatas[i].Getrequest() + "\n";
                    }        
                }
                return output;
            }
            else
            {
                return "permission error";
            }
        }

        public void CheckRequest(UserData userdata,int index)
        {
            if (userdata.GetUserType() == 2)
            {
                userDatas[index].Setrequest(null);
                userDatas[index].SetUserType(1);
            }
            else
            {
                Console.WriteLine("permission error");
            }
        }
    }
}
