using System;
namespace AbstractFactoryMethod
{
	public class LuxuryInterior : IInterior
	{
		public LuxuryInterior()
		{
		}

        public void Display()
        {
            Console.WriteLine("Luxury Interior");
        }
    }
}

