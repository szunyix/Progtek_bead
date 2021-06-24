using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vatera.Class;
using Vatera.Decorator.UserDecorator;

namespace Vatera.UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CreateUser_User_Success()
        {
            //Arrange
            User user = new User();

            //Act
            user.CreateUser("username", "password", "email@email.com");

            //Assert
            bool success = user.Email == "email@email.com" && user.UserName == "username";
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void CreateUser_MemberUser_Success()
        {
            //Arrange
            MemberUserDecorator memberUser = new MemberUserDecorator(new User());
            
            //Act
            memberUser.CreateUser("username", "password", "email@email.com");
            
            //Assert
            bool success = memberUser is MemberUserDecorator && memberUser.getUserName().Length != 0;
            Assert.IsTrue(success);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateUser_User_ExceptionThrow()
        {
            User user = new User();

            user.CreateUser("username", "password", "emailemail.com");
        }
    }
}
