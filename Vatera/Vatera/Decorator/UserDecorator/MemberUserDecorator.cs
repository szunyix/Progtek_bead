using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Class;

namespace Vatera.Decorator
{
    class MemberUserDecorator : AUserDecorator
    {
        public MemberUserDecorator(IUser user) : base(user)
        {
        }

        public IUser CreateUser()
        {
            user.CreateUser();
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
