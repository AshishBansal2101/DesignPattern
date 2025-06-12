using System;
namespace VisitorDesignPattern
{
	public interface ICartItem
	{
		public void Accept(IVisitor visitor);
	}
}

