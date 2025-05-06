using SingletonDesignPattern;

namespace SingletonDesignImplementation
{
    public class Program
    {
        public static void Main()
        {
            Thread t1 = new (() => DataBaseConnection("Ashish"));
            Thread t2 = new (() => DataBaseConnection("Bansal"));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.ReadLine();
        }

        public static void DataBaseConnection(string value)
        {
            DatabaseSingleton conn = DatabaseSingleton.GetInstance(value);
            Console.WriteLine("Hello  " + conn.Value);
        }
    }
}

