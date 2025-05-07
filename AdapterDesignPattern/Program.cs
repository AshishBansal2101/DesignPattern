namespace AdapterDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            FahrenAdaptee fahrenAdaptee = new();
            ITargetTemp targetTemp = new Adapter(fahrenAdaptee);

            Console.WriteLine("temp in fh: " + fahrenAdaptee.TempF());
            Console.WriteLine("temp in celcius: " + targetTemp.Celcius());

            Console.ReadKey();
        }
    }
}