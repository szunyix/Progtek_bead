using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vatera.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;

namespace Vatera.Storage.UnitTest
{
    [TestClass]
    public class TheStorageTests
    {
        [TestMethod]
        public void Create_Storage_Sucess()
        {
            //Arrange
            TheStorage storage = TheStorage.GetInstance();

            //Assert
            bool success = storage.ProductList != null;
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void Create2TheStorage_Success()
        {
            //Arrange
            TheStorage storage1 = TheStorage.GetInstance();
            TheStorage storage2 = TheStorage.GetInstance();

            //Assert
            bool success = storage1 == storage2;
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void AddItemTheStorage_Success()
        {
            //Arrange
            TheStorage storage = TheStorage.GetInstance();
            Item item = new Item(1, "Item", 20, 1);
            //Act
            storage.productadd(item);

            //Assert
            bool success = storage.ProductList.Contains(item);
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void RemoveItemTheStorage_Success()
        {
            //Arrange
            TheStorage storage = TheStorage.GetInstance();
            Item item = new Item(1, "Item", 20, 1);
            storage.productadd(item);

            //Act
            storage.getProductById(1);

            bool success = storage.getProductById(1) != null;

            //Assert            
            Assert.IsTrue(success);
        }
    }
}