using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface IWishList
    {
        int getWishListedItems();

        string getWishListedItem(int indexOfItem);

        void notifyMember();
    }
}
