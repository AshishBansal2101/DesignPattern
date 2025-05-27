namespace IteratorDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            Notebook notebook = new();
            notebook.AddPage("Page 1 - INTRO");
            notebook.AddPage("Page 2 - Overview");
            notebook.AddPage("Page 3 - Conclusion");

            Console.WriteLine("Pages from beginning");
            foreach(var page in notebook)
            {
                Console.WriteLine(page);
            }
            notebook.SetReverse();
            Console.WriteLine("Pages from End - in reverse");
            foreach (var page in notebook)
            {
                Console.WriteLine(page);
            }

            Console.ReadLine();
        }
    }
}