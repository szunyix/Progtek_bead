using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;
using Vatera.Interface;
using Vatera.Storage;

namespace Vatera.Decorator.UserDecorator
{
    class AdminUserDecorator : IUser
    {
        protected IUser user;
        public AdminUserDecorator(IUser user)
        {
            this.user = user;
        }

        public IUser CreateUser(string UserName, string Password, string Email)
        {
            user.CreateUser(UserName, Password, Email);
            setMembership(user);
            return user;
        }

        public void setMembership(IUser user)
        {
            User memberUser = (User)user;
            memberUser.Membership = "Admin";
        }

        public void removeItem(TheStorage storage, int itemIndex)
        {
            Item itemToRemove = storage.getProductById(itemIndex);
            storage.productRemove(itemToRemove);
        }

        public void addItem(TheStorage storage, Item itemToAdd)
        {
            storage.productadd(itemToAdd);
        }
    }
}
