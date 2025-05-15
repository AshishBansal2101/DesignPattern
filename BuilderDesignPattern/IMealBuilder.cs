using System;
namespace BuilderDesignPattern
{
	public interface IMealBuilder
	{
		void Starter();
		void MainCourse();
		void Dessert();
		Meal GetMeal();
	}
}

