using System;
namespace DecoratorDesignPattern
{
	public class NotifierDecorator : INotifier
	{
		private readonly INotifier _notifier;
		public NotifierDecorator(INotifier notifier)
		{
			_notifier = notifier;
		}

		public virtual void Send(string msg)
		{
			_notifier.Send(msg);
		}

	}
}

