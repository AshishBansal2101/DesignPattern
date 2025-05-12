using System;
namespace DecoratorDesignPattern
{
	public class EmailDecorator : NotifierDecorator
	{
		public EmailDecorator(INotifier notifier) : base(notifier)
		{
		}

		public override void Send(string msg)
		{
			base.Send(msg);
			Console.WriteLine("This rocks... Email is sent.." + msg);
		}
	}
}

