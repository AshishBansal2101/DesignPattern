using System;
namespace BuilderDesignPattern
{
	public class VegMealBuilder : IMealBuilder
    {
        private Meal _meal;
        public VegMealBuilder()
        {
            _meal = new();
        }

        public void Dessert()
        {
            _meal.Add("Gulab Jamun Jalebi ..");
        }

        public Meal GetMeal()
        {
            Meal finalMeal = _meal;
            _meal = new();
            return finalMeal;
        }

        public void MainCourse()
        {
            _meal.Add("Panner...");
        }

        public void Starter()
        {
            _meal.Add("Vegetable Sandwich..");
        }
    }
}

