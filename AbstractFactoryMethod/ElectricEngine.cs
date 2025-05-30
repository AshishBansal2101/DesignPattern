using System;
namespace AbstractFactoryMethod
{
	public class ElectricEngine : IEngine
	{
		public ElectricEngine()
		{
		}

        public void Start()
        {
            Console.WriteLine("Electric Engine");
        }
    }
}

