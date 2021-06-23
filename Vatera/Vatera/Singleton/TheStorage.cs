using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Interface;
using Vatera.Class;

/// <summary>
/// Summary description for Singleton
/// </summary>
namespace Vatera.Storage
{
	public class TheStorage : IStorage //public Item getProductById
	{
		private static TheStorage uniqueInstance = null;

		private List<Item> productList = new List<Item>();
		public List<Item> ProductList
		{
			get 
			{
				return productList;
			}
		}

		private TheStorage() {	}

		public void productadd(Item product)
        {
			ProductList.Add(product);
        }

		public bool BeinProduct(Item product)
        {
            foreach (Item item in ProductList) {
                if (product == item) {
					return true;
					//show message : item found
				}			
            }
			return false;
			//show message : item dont found
		}
		public Item getProductById(int Id)
        {
            foreach (Item item in ProductList)
            {
                if (Id == item.Id)
                {
					return item;
                }
            }
			return null;
        }
		public void productRemove(Item product)
        {
			foreach (Item item in ProductList)
			{
				if (product == item)
				{
					ProductList.Remove(item);
				}
			}
			//show message : item removed
		}
		
		
		public static TheStorage GetInstance()
		{
			if (uniqueInstance == null) 
			{
				uniqueInstance = new TheStorage(); 
			}
			
			return uniqueInstance;
		}


	}

}
