using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    public interface IUser
    {
        IUser CreateUser();

        void update();

        int getWishListedItems(IUser user);

        string getWishListedItem(int i, IUser user);
    }
}
