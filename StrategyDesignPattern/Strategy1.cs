using System;
namespace StrategyDesignPattern
{
	public class Strategy1 : IStrategy
	{
		public Strategy1()
		{
		}

		public object? Operation(object str)
		{
			var elem = str as List<string>;
			elem?.Sort();
			return elem;
		}
	}
}

