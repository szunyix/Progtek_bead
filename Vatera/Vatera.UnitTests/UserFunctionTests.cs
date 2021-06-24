using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vatera.Class;
using Vatera.Storage;
using Vatera.Decorator.UserDecorator;

namespace Vatera.UnitTests
{
    [TestClass]
    public class UserFunctionTests
    {
        [TestMethod]
        public void addItem_AdminUser_Success()
        {
            //Arrange
            AdminUserDecorator adminUser = new AdminUserDecorator(new User());
            adminUser.CreateUser("username", "password", "email@email.com");
            TheStorage storage = TheStorage.GetInstance();
            Item itemToAdd = new Item(1,"testProduct", 999, 1);

            //Act
            adminUser.addItem(itemToAdd);


            //Assert
            bool success = storage.ProductList.Contains(itemToAdd);
            Assert.IsTrue(success);
        }

    }
}
