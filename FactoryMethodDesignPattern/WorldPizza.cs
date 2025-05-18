using System;
namespace FactoryMethodDesignPattern
{
	public class WorldPizza : PizzaStore
	{
		public WorldPizza()
		{
		}

        public override IPizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new CheesePizza(),
                "Farmhouse" => new FarmhousePizza(),
                _ => new CheesePizza(),
            };
        }
    }
}

