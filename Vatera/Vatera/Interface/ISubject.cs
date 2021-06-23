using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface ISubject
    {
        //void RegisterObserver(IWishList user);
        void NotifyObserver(string item);
    }
}
