namespace FactoryMethodDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            PizzaStore pizzaStore = new WorldPizza();
            IPizza pizza = pizzaStore.OrderPizza("Farmhouse");
            Console.WriteLine("price   " + pizza.GetPrice());

            IPizza cheesePizza = pizzaStore.OrderPizza("Cheese");
            Console.WriteLine("price   " + cheesePizza.GetPrice());

            Console.ReadLine();
        }
    }
}