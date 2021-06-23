using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Decorator.UserDecorator;

namespace Vatera.Class
{
    class UserCollection : IUserCollectionAdmin
    {
        private UserCollection() { }

        private static UserCollection uniqueInstance = null;

        private List<IUser> userList;
        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
        }
        
        public void addUser(IUser user)
        {
            userList.Add(user);
        }

        public IUser findUserByName(string Name)
        {
            foreach (IUser user in userList)
            {
                if (user.getUserName() == Name)
                    return user;
            }
            return null;
        }

        public void banUser(IUser user)
        {

        }

        public List<AdminUserDecorator> getAdmins()
        {
            List<AdminUserDecorator> temp = new List<AdminUserDecorator>();
            foreach (IUser user in userList)
            {
                if (user is AdminUserDecorator)
                    temp.Add((AdminUserDecorator)user);
            }
            return temp;
        }
        public static UserCollection GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new UserCollection();
            }

            return uniqueInstance;
        }


    }
}
