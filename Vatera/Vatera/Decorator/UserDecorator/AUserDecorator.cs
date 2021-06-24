using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;
using Vatera.Interface;
using Vatera.Storage;

namespace Vatera.Decorator.UserDecorator
{
    public abstract class AUserDecorator : IUser
    {
        public List<Item> WishList { get; set; }
        protected IUser user;
        public AUserDecorator(IUser user)
        {
            this.user = user;
        }

        public virtual IUser CreateUser(string UserName, string Password, string Email)
        {
            return user.CreateUser(UserName, Password, Email);
        }

        public virtual void addItem(TheStorage storage, Item itemToAdd)
        {
            storage.productadd(itemToAdd);
        }

        public virtual string getUserName()
        {
            return user.getUserName();
        }

        public virtual int getWishListedItems()
        {
            return WishList.Count;
        }

        public virtual string getWishListedItem(int indexOfItem)
        {
            return WishList[indexOfItem].ToString();
        }

        public virtual void notifyUser()
        {
            notifyUser();
        }
    }
}