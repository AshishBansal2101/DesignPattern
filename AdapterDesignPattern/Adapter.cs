using System;
namespace AdapterDesignPattern
{
	public class Adapter : ITargetTemp
	{
		private readonly FahrenAdaptee _fahrenAdaptee;

		public Adapter(FahrenAdaptee fahrenAdaptee)
		{
			_fahrenAdaptee = fahrenAdaptee;
		}

		public double Celcius()
		{
			return (_fahrenAdaptee.TempF()-32)*5/9;
		}
	}
}

