using System;
namespace BuilderDesignPattern
{
	public class Waiter
	{
		private IMealBuilder _mealBuilder;

		public void SetBuilder(IMealBuilder mealBuilder)
		{
			_mealBuilder = mealBuilder;
		}

		public Waiter(IMealBuilder mealBuilder)
		{
			_mealBuilder = mealBuilder;
		}

		public Waiter()
		{
			_mealBuilder = new VegMealBuilder();//default
		}

		public void ThreeCourseMeal()
		{
			Console.WriteLine("Enjoy your 3 course meal");
			_mealBuilder.Starter();
			_mealBuilder.MainCourse();
			_mealBuilder.Dessert();
		}

        public void LightMeal()
        {
            Console.WriteLine("Enjoy your Light meal");
            _mealBuilder.Starter();
            _mealBuilder.MainCourse();
        }

    }
}

