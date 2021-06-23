using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Interface
{
    interface IUserCollectionMember
    {
        List<IUser> UserList { get; }
    }
}
