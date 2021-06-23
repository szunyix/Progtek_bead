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

		private List<Item> ProductList = new List<Item>();
		public List<Item> productlist { get; }

		private TheStorage() {	}

		public void productadd(Item product)
        {
			productlist.Add(product);
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
		public void productRemove(Item product)
        {
			foreach (Item item in ProductList)
			{
				if (product == item)
				{
					productlist.Remove(item);
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
