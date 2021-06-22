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

        public IUser CreateUser(string UserName, string Password, string Email)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            Balance = 0;

            return this;
        }

        
        public string getWishListedItem(int i, IUser user)
        {
            throw new NotImplementedException();
        }

        public int getWishListedItems(IUser user)
        {
            return WishList.Length;
        }

        public void notifyUser()
        {
            
        }
    }
}
