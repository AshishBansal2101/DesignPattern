using System;
namespace BuilderDesignPattern
{
	public class NonVegMealBuilder : IMealBuilder
	{
        private Meal _meal;
		public NonVegMealBuilder()
		{
            _meal = new();
		}

        public void Dessert()
        {
            _meal.Add("cake..");
        }

        public Meal GetMeal()
        {
            Meal finalMeal = _meal;
            _meal = new();
            return finalMeal;
        }

        public void MainCourse()
        {
            _meal.Add("Chicken...");
        }

        public void Starter()
        {
            _meal.Add("Egg Sandwich..");
        }
    }
}

