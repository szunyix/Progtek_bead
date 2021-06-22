using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Storage;
using Vatera.Class;

namespace Vatera.Decorator
{
    class MemberUserDecorator : AUserDecorator
    {
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
    }
}
