using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Class
{
    public class User : IObserver, IUser
    {
        
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public double Balance { get; set; }

        public string Membership { get; set; }

        public string[] WishList { get; set; }

        /*public User(string userName, string password, string email, double balance)
        {
            this.userName = userName;
            this.passWord = password;
            this.email = email;
            this.balance = balance;
            //WishList = wishList;
        }*/

        public IUser CreateUser()
        {
            UserName = "defaultUserName";
            Password = "defaultPassword";
            Email = "defaultEmail";
            Balance = 0;

            return this;
        }

        public void update()
        {
            
        }
    }
}
