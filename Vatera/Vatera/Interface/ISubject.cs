using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObserver(string item);
    }
}
