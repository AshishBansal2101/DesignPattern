using System;
namespace DecoratorDesignPattern
{
    public class SMSDecorator : NotifierDecorator
    {
        public SMSDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("This is awesome... SMS is also sent  .. " + msg);
        }
    }
}

