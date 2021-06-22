using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;

namespace Vatera.Class
{
    public class Subject : ISubject
    {
        private List<IObserver> users = new List<IObserver>();

        private string productName;
        public string ProductName { get; set; }

        private double productPrice;
        public double ProductPrice { get; set; }

        private int inStock;
        public int InStock { get; set; }

        public Subject(string productName, double productPrice, int inStock)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            InStock = inStock;
        }

        public void setInStock(Subject subject)
        {
            if (subject.inStock == 0)
                NotifyObserver(subject.productName.ToString());
            //Storage.item.add(subject)
        }

        public void NotifyObserver(string ProductName)
        {
            foreach (IUser user in users)
            {
                CheckWishList(user);
            }
        }

        //Check and Update
        private void CheckWishList(IUser user)
        {
            string product;
            for (int i = 0; i < user.getWishListedItems(user); i++)
            {
                product = user.getWishListedItem(i, user);
                if (ProductName == product)
                    user.update();
            }
        }

        public void RegisterObserver(IObserver user)
        {
            Console.WriteLine("Observer hozzáadás");
            users.Add(user);
        }
    }
}
