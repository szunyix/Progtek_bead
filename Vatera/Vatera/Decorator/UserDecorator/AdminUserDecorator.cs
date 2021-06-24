using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;
using Vatera.Interface;
using Vatera.Storage;

namespace Vatera.Decorator.UserDecorator
{
    class AdminUserDecorator : AUserDecorator, IUser
    {
        protected IStorage storage;
        public AdminUserDecorator(IUser user) : base(user)
        {
            this.user = user;
            storage = TheStorage.GetInstance();
        }

        public override IUser CreateUser(string UserName, string Password, string Email)
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

        public void addItem(Item itemToAdd)
        {
            storage.productadd(itemToAdd);
        }

        public void banMember(string memberUserName, DateTime untilWhen)
        {
            throw new NotImplementedException();
        }
    }
}
