using System;
namespace VisitorDesignPattern
{
	public interface IVisitor
	{
		public void Visit(Book book);
		public void Visit(Electronics electronics);
	}
}

