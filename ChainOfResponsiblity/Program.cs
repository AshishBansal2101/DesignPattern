namespace ChainOfResponsiblity;

class Program
{
    static void Main(string[] args)
    {
        SupportHandler customerSupport = new CustomerSupport();
        SupportHandler technicalSupport = new TechnicalSupport();
        SupportHandler salesSupport = new SalesSupport();

        customerSupport.SetNext(technicalSupport).SetNext(salesSupport);

        Client client = new(customerSupport);

        client.AddRequest("tech bug");
        client.AddRequest("cancel order");
        client.AddRequest("discount $5 on Nike Shoes");
        client.AddRequest("admin - password modified");


        client.HandleRequets();

        Console.ReadLine();
    }
}

