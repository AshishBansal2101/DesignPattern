using System;
namespace StrategyDesignPattern
{
	public class StrategyContext
	{
		private IStrategy? _strategy;
		public StrategyContext()
		{
		}

		public StrategyContext(IStrategy strategy)
		{
			_strategy = strategy;
		}

		public void SetStrategy(IStrategy strategy)
		{
			_strategy = strategy;
		}

		public void DoSomething()
		{
			Console.WriteLine("hey guys.... this is common for all operations..");
			var res = _strategy?.Operation(new List<string>(){"x","b","a"});
			Console.WriteLine("Here are my elements after doing requested operation");
			foreach(var elem in res as List<string>??new List<string>())
			{
				Console.Write(elem + " ...");
			}

			Console.WriteLine();
		}
	}
}

