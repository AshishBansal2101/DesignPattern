
using System;
namespace AbstractFactoryMethod
{
	public class PetrolEngine : IEngine
	{
		public PetrolEngine()
		{
		}

        public void Start()
        {
            Console.WriteLine("Petrol Engine");
        }
    }
}

