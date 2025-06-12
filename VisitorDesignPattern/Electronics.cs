using System;
namespace VisitorDesignPattern
{
	public class Electronics : ICartItem
	{
		public string Name { get; }
		public int Price { get; }
		public Electronics(string name, int price)
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

