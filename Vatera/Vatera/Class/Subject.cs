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

        public void setInStock()
        {

        }

        public void NotifyObserver()
        {
            //foreach -> wishlist
            //users.update()
        }

        public void RegisterObserver(IObserver user)
        {
            Console.WriteLine("Observer hozzáadás");
            users.Add(user);
        }
    }
}
