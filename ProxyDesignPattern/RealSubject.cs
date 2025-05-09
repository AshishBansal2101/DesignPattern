using System;
namespace ProxyDesignPattern
{
	public class RealSubject : ISubject
	{
		public RealSubject()
		{
		}

		public void Request()
		{
			Console.WriteLine("....RealSubject Reached....");
		}
	}
}

