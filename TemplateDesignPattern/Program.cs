namespace TemplateDesignPattern.Program
{
    public static class Program
    {
        public static void Main()
        {
            CaffeineBeverage coffee = new CoffeeBeverage();
            coffee.Template();

            CaffeineBeverage tea = new TeaBeverage();
            tea.Template();

            Console.ReadKey();
        }
    }
}