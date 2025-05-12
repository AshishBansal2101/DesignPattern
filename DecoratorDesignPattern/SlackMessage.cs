using System;
namespace DecoratorDesignPattern
{
    public class SlackDecorator : NotifierDecorator
    {
        public SlackDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("Now this is offical messsage from slack... Pay attention.." + msg);
        }
    }
}

