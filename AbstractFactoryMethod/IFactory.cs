using System;
namespace AbstractFactoryMethod
{
	public interface IFactory
	{
		IEngine GetEngine();
		IInterior GetInterior();
	}
}

