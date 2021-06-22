using System;

/// <summary>
/// Summary description for Singleton
/// </summary>
namespace Vatera.Storage
{
	public class TheStorage
	{
		private static TheStorage uniqueInstance = null;
		
		private TheStorage() 
		{
			//empty
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
