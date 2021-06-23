using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;
using Vatera.Storage;

namespace Vatera.Interface
{
    interface IStorage
    {
        public Item getProductById(int Id);
        public static TheStorage GetInstance() => throw new NotImplementedException();
        public void productadd(Item product);
    }
}
