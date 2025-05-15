namespace BuilderDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Veg Meal.....\n");
            IMealBuilder vegMealBuilder = new VegMealBuilder();
            Waiter waiter = new(vegMealBuilder);
            waiter.ThreeCourseMeal();
            vegMealBuilder.GetMeal().ShowMeal();


            Console.WriteLine("\nNon Veg Meal...\n");
            var nonVegMealBuilder = new NonVegMealBuilder();
            waiter = new(nonVegMealBuilder);
            waiter.LightMeal();
            nonVegMealBuilder.GetMeal().ShowMeal();


            Console.WriteLine("\nCustom Meal\n");
            var customMealBuilder = new NonVegMealBuilder();
            customMealBuilder.MainCourse();
            customMealBuilder.Dessert();
            customMealBuilder.GetMeal().ShowMeal();

            Console.ReadKey();
        }
    }
}