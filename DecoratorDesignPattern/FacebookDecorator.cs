using System;
namespace DecoratorDesignPattern
{
    public class FacebookDecorator : NotifierDecorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("Have some fun  ... Facebook msg is sent..." + msg);
        }
    }
}

