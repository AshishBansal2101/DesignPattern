using System;
namespace ProxyDesignPattern
{
	public class Proxy : ISubject
	{
		private ISubject _realSubject;
		public Proxy(ISubject realSubject)
		{
			_realSubject = realSubject;
		}

		public void Request()
		{
			if (IsAccess())
			{
				_realSubject.Request();
				Logging();
			}
		}

		private static bool IsAccess()
		{
			Console.WriteLine("Access is true...");
			return true;
		}

		private static void Logging()
		{
			Console.WriteLine("Proxy is logging");
		}
	}
}

