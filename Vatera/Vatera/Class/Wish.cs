using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Class
{
    class Wish
    {
        public IUser user;
        public ISubject item;
        public Wish(IUser user, ISubject item)
        {
            this.user = user;
            this.item = item;
        }
    }
}
