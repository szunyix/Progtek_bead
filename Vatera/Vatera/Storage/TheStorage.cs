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
	public class TheStorage
	{
		private static TheStorage uniqueInstance = null;

		private List<Subject> ProductList = new List<Subject>();
		public List<Subject> productlist { get; }

		private TheStorage() {	}

		public void productadd(Subject product)
        {
			productlist.Add(product);
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
