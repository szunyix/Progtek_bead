using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vatera.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vatera.Class.UnitTests
{
    [TestClass()]
    public class ItemTests
    {
        
        [TestMethod()]      
        public void RegisterObserver_Success()
        {
            //Arrange
            Item item = new Item("PS4", 250, 5);
            User user = new User();
            user.CreateUser("username", "password", "email@email.com");

            //Act
            item.RegisterObserver(user, item);

            //Assert
            bool success = user is User && user.UserName == "username" && item.ProductName == "PS4";
            Assert.IsTrue(success);
        }
    }
}