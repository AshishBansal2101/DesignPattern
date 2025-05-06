using System;
namespace StrategyDesignPattern
{
	public interface IStrategy
	{
		object? Operation(object str);
	}
}

