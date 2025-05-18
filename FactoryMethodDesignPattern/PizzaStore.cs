using System;
namespace FactoryMethodDesignPattern
{
	public abstract class PizzaStore
	{
		public abstract IPizza CreatePizza(string type);
		public IPizza OrderPizza(string type)
		{
			IPizza pizza = CreatePizza(type);
			pizza.Prepare();
			Console.WriteLine("Baking");
			Console.WriteLine("Slicing");
            Console.WriteLine("Boxing");
            return pizza;
		}
	}
}

