using System;
namespace FlyweightDesignPattern
{
	public class TreeFactory
	{
		private Dictionary<string, TreeType> _factory;
		public TreeFactory()
		{
			_factory = new();
        }

		public TreeType GetTreeType(string name, string color, string texture)
		{
			string key = $"{name}_{color}_{texture}";
			if (!_factory.TryGetValue(key, out TreeType? value))
			{
                value = new TreeType(name, color, texture);
                _factory.Add(key, value);
			}

			return value;
		}

		public void AllTreeTypes()
		{
			foreach(var key in _factory.Keys)
			{
				Console.WriteLine($"Showing TreeTypes _ {key}");
			}
		}
	}
}

