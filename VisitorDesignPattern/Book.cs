using System;
namespace VisitorDesignPattern
{
	public class Book : ICartItem
	{
		public string Name { get; }
		public int Price { get; }
		public Book(string name, int price)
		{
			Name = name;
			Price = price;
		}

        public void Accept(IVisitor visitor)
        {
			visitor.Visit(this);
        }
    }
}

