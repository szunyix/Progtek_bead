using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Decorator
{
    public abstract class AUserDecorator : IUser
    {
        protected IUser user;
        public AUserDecorator(IUser user)
        {
            this.user = user;
        }

        public virtual IUser CreateUser(string UserName, string Password, string Email)
        {
            return user.CreateUser(UserName, Password, Email);
        }

        /*public virtual int getWishListedItems()
        {
            return user.getWishListedItems(user);
        }

        public virtual string getWishListedItem(int i, IUser user)
        {
            return user.getWishListedItem(i);
        }

        public virtual void notifyUser()
        {
            user.notifyUser();
        }*/
    }
}