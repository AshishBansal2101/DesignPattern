namespace PrototypeDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            PersonModel p1 = new PersonModel()
            { Age = 20, Name = "Ashish", Info = new IdInfo(2121) };

            var p2 = p1.ShallowCopy();
            var p3 = p1.DeepCopy();

            Display(p1);
            Display(p2);
            Display(p3);

            p1.Age = 10;
            p1.Name = "Hello";
            p1.Info.Id = 1212;

            Display(p1);
            Display(p2);
            Display(p3);

            Console.ReadKey();
        }

        public static void Display(PersonModel p)
        {
            Console.WriteLine("Age  ..." + p.Age + "....Name   .." + p.Name + "....Infoid..." + p.Info?.Id);
        }
    }
}