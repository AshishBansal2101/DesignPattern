using System;
namespace VisitorDesignPattern
{
	public class NormalCustomer : IVisitor
	{
		public NormalCustomer()
		{
		}

        public void Visit(Book book)
        {
            Console.WriteLine($"Name of book : {book.Name}, price of book {book.Price} and normal customer gets a discount of 5%");
        }

        public void Visit(Electronics electronics)
        {
            Console.WriteLine($"Name of electronic item : {electronics.Name}, price of electronic {electronics.Price} and normal customer gets a discount of 10%");
        }
    }
}

