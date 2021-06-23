using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Storage;

namespace Vatera.Class
{
    public class Item : ISubject , IItem
    {
        private List<IWishList> wishListedItems = new List<IWishList>();

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
        public string ProductName { get; set; }  

        private double productPrice;
        public double ProductPrice { get; set; }

        private int inStock;
        public int InStock { get; set; }

        public Item(string productName, double productPrice, int inStock)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            InStock = inStock;
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

        //Check and Update
        private void CheckWishList(IWishList item)
        {
            string product;
            for (int i = 0; i < item.getWishListedItems(); i++)
            {
                product = item.getWishListedItem(i);
                if (ProductName == product)
                    item.notifyMember();
            }
        }

        //Method for register observers-> add wished item to member
    }
}
