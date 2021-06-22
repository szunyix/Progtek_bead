using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    public interface IUser
    {
        IUser CreateUser(string UserName, string Password, string Email);
        void notifyUser();

        int getWishListedItems(IUser user);

        string getWishListedItem(int i, IUser user); //"i" is to be renamed
    }
}
