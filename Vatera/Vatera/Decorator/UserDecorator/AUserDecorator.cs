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

        public virtual IUser CreateUser()
        {
            return user.CreateUser();
        }

        public virtual int getWishListedItems(IUser user)
        {
            return user.getWishListedItems(user);
        }

        public virtual string getWishListedItem(int i, IUser user)
        {
            return user.getWishListedItem(i, user);
        }

        public virtual void notifyUser()
        {
            user.notifyUser();
        }
    }
}