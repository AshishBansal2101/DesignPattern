using System;
namespace FactoryMethodDesignPattern
{
	public class CheesePizza : IPizza
	{
		public CheesePizza()
		{
		}

        public int GetPrice()
        {
            return 100;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
        }
    }
}

