namespace DecoratorDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            INotifier simple = new BaseNotifier();
            simple.Send("Let's try simple one first...");

            INotifier emailSms = new EmailDecorator
                                (new SMSDecorator
                                (new BaseNotifier()));
            emailSms.Send("You won 50,000 $");

            INotifier sentEverything = new FacebookDecorator
                                        (new EmailDecorator
                                        (new SlackDecorator
                                        (new SMSDecorator
                                        (new BaseNotifier()))));

            sentEverything.Send("SomeThing Important... Here Maybe servers down...");

            Console.Read();
        }
    }
}