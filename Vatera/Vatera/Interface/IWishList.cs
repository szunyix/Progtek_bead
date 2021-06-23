using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface IWishList
    {
        int NumberOfWishListedItems();

        string getWishListedItem(int indexOfItem);

        void notifyMember();
    }
}
