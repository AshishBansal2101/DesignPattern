using System;
namespace FacadeDesignPattern
{
	public class Client
	{
		public void Operate(FacadeClass facade)
		{
			Console.WriteLine(facade.Operation());
		}
	}
}

