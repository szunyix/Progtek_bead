using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface IUserCollectionAdmin : IUserCollectionMember
    {
        void banUser(IUser user);
    }
}
