namespace FlyweightDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        Forest forest = new Forest();
        forest.AddTree("Mango", "orange", "smooth", 10, 20);
        forest.AddTree("Mango", "orange", "smooth", 12, 25);
        forest.AddTree("Mango", "Red", "Rough", 15, 26);
        forest.AddTree("Oak", "Brown", "Rough", 100, 21);
        forest.AddTree("Banyan", "Black", "Sharp", 98, 2);
        forest.AddTree("Banyan", "Black", "Sharp", 12, 100);

        forest.DrawTrees();

        Console.WriteLine(".......___________...........");
        forest.ShowTypes();

        Console.ReadLine();

    }
}

