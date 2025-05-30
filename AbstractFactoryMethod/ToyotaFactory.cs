using System;
namespace AbstractFactoryMethod
{
	public class ToyotaFactory : IFactory
	{
        public IEngine GetEngine()
        {
            return new PetrolEngine();
        }

        public IInterior GetInterior()
        {
            return new BasicInterior();
        }
    }
}

