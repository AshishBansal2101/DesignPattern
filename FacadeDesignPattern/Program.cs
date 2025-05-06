
namespace FacadeDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            Subsystem1 subsystem1 = new();
            Subsystem2 subsystem2 = new();

            FacadeClass facadeClass = new(subsystem1, subsystem2);

            Client client = new();
            client.Operate(facadeClass);

            Console.ReadLine();
        }
    }
}
