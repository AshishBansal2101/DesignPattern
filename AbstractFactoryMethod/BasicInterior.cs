using System;
namespace AbstractFactoryMethod
{
	public class BasicInterior : IInterior
	{
		public BasicInterior()
		{
		}

        public void Display()
        {
            Console.WriteLine("Basic Interior");
        }
    }
}

