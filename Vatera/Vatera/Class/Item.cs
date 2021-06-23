using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Storage;

namespace Vatera.Class
{
    public class Item : ISubject , IItem
    {
        private List<Wish> wishListedItems = new List<Wish>();

        private int id;

        public int Id
        { 
            get 
            {
                return id;
            }

            set 
            {
                id = value;    
            }
        }

        private string productName;
        public string ProductName {
            get { return productName; }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Product's name cannot be null!");
                if (value.Length < 3)
                    throw new Exception("ProductName must be at least 3 characters long!");
                productName = value;
            }
        }  

        private double productPrice;
        public double ProductPrice {
            get { return productPrice; }
            set
            {
                if (value == 0)
                    throw new Exception("Product cannot be free!");
                productPrice = value;
            }
        }

        private int inStock;
        public int InStock {
            get { return inStock; }
            set { inStock = value; }
        }

        public Item(string productName, double productPrice, int inStock)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            InStock += inStock;
        }

        public void setInStock(Item subject)
        {
            if (subject.inStock == 0)
                NotifyObserver(subject.productName.ToString());
            IStorage Storage = IStorage.GetInstance();
            Storage.productadd(subject);
        }

        public void NotifyObserver(string ProductName)
        {
            foreach (IWishList item in wishListedItems)
            {
                CheckWishList(item);
            }
        }

        private void CheckWishList(IWishList item)
        {
            string product;
            for (int i = 0; i < item.NumberOfWishListedItems(); i++)
            {
                product = item.getWishListedItem(i);
                if (ProductName == product)
                    item.notifyMember();
            }
        }

        public void RegisterObserver(IUser user, ISubject item)
        {
            wishListedItems.Add(new Wish(user, item));
        }
    }
}
