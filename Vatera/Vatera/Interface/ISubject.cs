using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IUser user, ISubject item);
        void NotifyObserver(string item);
    }
}
