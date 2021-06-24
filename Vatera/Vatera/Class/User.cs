using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Class
{
    public class User : IObserver, IUser
    {
        private string userName;
        public string UserName {
            get
            {
                return userName;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Username must be at least 6 characters long!");
                userName = value;
            }
        }

        private string password;
        public string Password {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Password must be at least 6 characters long!");
                password = value;
            }
        }

        private string email;
        public string Email {
            get
            {
                return email;
            }
            set
            {
                if (!value.Contains('@'))
                    throw new Exception("Email must be a valid address!");
                email = value;
            }
        }

        private double balance;
        public double Balance {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Balance cannot go under $0");
                balance = value;
            }
        }

        public string Membership { get; set; }
      

        /*public User(string userName, string password, string email, double balance)
        {
            this.userName = userName;
            this.passWord = password;
            this.email = email;
            this.balance = balance;
            //WishList = wishList;
        }*/

        public IUser CreateUser(string UserName, string Password, string Email)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            Balance = 0;

            return this;
        }

        public string getUserName()
        {
            return UserName;
        }

        public void notifyUser()
        {
            
        }
    }
}
