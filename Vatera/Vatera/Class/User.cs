using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Class
{
    public class User : IObserver
    {

        private string userName;
        //public string UserName { get; set; }

        private string passWord;
        //public string Password { get; set; }

        private string email;
        //public string Email { get; set; }

        private double balance;
        //public double Balance { get; set; }

        //public string[] WishList { get; set; }

        public User(string userName, string password, string email, double balance)
        {
            this.userName = userName;
            this.passWord = password;
            this.email = email;
            this.balance = balance;
            //WishList = wishList;
        }

        public void update()
        {
            
        }
    }
}
