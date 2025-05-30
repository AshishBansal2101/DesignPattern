using System;
namespace AbstractFactoryMethod
{
    public class TeslaFactory : IFactory
    {
        public IEngine GetEngine()
        {
            return new ElectricEngine();
        }

        public IInterior GetInterior()
        {
            return new LuxuryInterior();
        }
    }
}

