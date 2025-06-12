using System;
namespace VisitorDesignPattern
{
	public class PremiumCustomer : IVisitor
	{
		public PremiumCustomer()
		{
		}

        public void Visit(Book book)
        {
            Console.WriteLine($"Name of book : {book.Name}, price of book {book.Price} and Premium customer gets a discount of 10%");
        }

        public void Visit(Electronics electronics)
        {
            Console.WriteLine($"Name of electronic item : {electronics.Name}, price of electronic {electronics.Price} and Premium customer gets a discount of 25%");
        }
    }
}

