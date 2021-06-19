using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Decorator
{
    public abstract class UserDecorator : IUser
    {
        protected IUser user;
        public UserDecorator(IUser user)
        {
            this.user = user;
        }

        public virtual IUser CreateUser()
        {
            return user.CreateUser();
        }
    }
}