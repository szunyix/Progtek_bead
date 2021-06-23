using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    public interface IUser
    {
        IUser CreateUser(string UserName, string Password, string Email);
        string getUserName();
    }
}
