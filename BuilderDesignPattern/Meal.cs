using System;
namespace BuilderDesignPattern
{
	public class Meal
	{
		private List<string> _meals = new();
		public Meal()
		{
		}

		public void Add(string meal)
		{
			_meals.Add(meal);
		}

		public void ShowMeal()
		{
			Console.WriteLine("Enjoy your Meal");
			foreach(var meal in _meals)
			{
				Console.Write(meal+ "  ");
			}
			Console.WriteLine();
		}
	}
}

