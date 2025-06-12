namespace VisitorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        List<ICartItem> cartItems = new() { new Book("Harry Potter",120), new Electronics("LG Fridge", 12000) };
        IVisitor normalCustomer = new NormalCustomer();
        IVisitor premiumCustomer = new PremiumCustomer();
        foreach(var item in cartItems)
        {
            Console.WriteLine("Normal discount>>>>>>");
            item.Accept(normalCustomer);
            Console.WriteLine("Special disount>>>>>>");
            item.Accept(premiumCustomer);
        }

        Console.WriteLine("..........");
        Console.ReadLine();
    }
}

