namespace StrategyDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            StrategyContext strategyContext = new();

            strategyContext.SetStrategy(new Strategy1());
            strategyContext.DoSomething();

            strategyContext.SetStrategy(new Strategy2());
            strategyContext.DoSomething();


            Console.ReadLine();
        }
            
    }
}