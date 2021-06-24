using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Storage;
using Vatera.Class;

namespace Vatera.Decorator.UserDecorator
{
    public class MemberUserDecorator : AUserDecorator
    {      
        public DateTime BannedUntil;
        public MemberUserDecorator(IUser user) : base(user)
        {
        }

        public IUser CreateMemberUser(string UserName, string Password, string Email)
        {
            user.CreateUser(UserName, Password, Email);
            setMembership(user);
            return user;
        }

        public void setMembership(IUser user)
        {
            User memberUser = (User)user;
            memberUser.Membership = "Member";
        }

        public List<Item> getStock(TheStorage storage)
        {
            throw new NotImplementedException("Storage needs methods for this.");
            //return storage.getItems();
        }

        public void notifyMember()
        {
            Console.WriteLine("Hello " + this.user.getUserName().ToString() + ", your wished item is now available!");
        }
    }
}
