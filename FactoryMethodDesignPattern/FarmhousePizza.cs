using System;
namespace FactoryMethodDesignPattern
{
	public class FarmhousePizza : IPizza
	{
		public FarmhousePizza()
		{
		}

        public int GetPrice()
        {
            return 250;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing Farmhouse Pizza");
        }
    }
}

