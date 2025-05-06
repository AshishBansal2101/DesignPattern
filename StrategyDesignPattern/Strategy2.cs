using System;
namespace StrategyDesignPattern
{
	public class Strategy2 : IStrategy
	{
		public Strategy2()
		{
		}

        public object? Operation(object str)
        {
            var elem = str as List<string>;
            elem?.Sort();
            elem?.Reverse();
            return elem;
        }
    }
}

