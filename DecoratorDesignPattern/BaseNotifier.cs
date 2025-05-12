using System;
namespace DecoratorDesignPattern
{
	public class BaseNotifier : INotifier
	{
		public BaseNotifier()
		{
		}

		public void Send(string msg)
		{
			Console.WriteLine("Base    " + msg);
		}
	}

}

