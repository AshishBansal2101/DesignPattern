namespace ProxyDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Using RealSubject");
            ISubject subject = new RealSubject();
            Client client = new(subject);
            client.Process();

            Console.WriteLine("Using Proxy");
            ISubject proxy = new Proxy(subject);
            Client client1 = new(proxy);
            client1.Process();

            Console.ReadKey();
        }
    }
}