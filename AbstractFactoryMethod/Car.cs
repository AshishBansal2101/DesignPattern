using System;
namespace AbstractFactoryMethod
{
	public class Car
	{
		private IEngine _engine;
		private IInterior _interior;
		public Car(IFactory factory)
		{
			_engine = factory.GetEngine();
			_interior = factory.GetInterior();
		}

		public void Build()
		{
			Console.WriteLine("Building Car...");
			_engine.Start();
			_interior.Display();
			Console.WriteLine("Car is Ready");
		}
		
	}
}

