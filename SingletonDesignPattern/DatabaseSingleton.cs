namespace SingletonDesignPattern
{
	public class DatabaseSingleton
	{
		private static  DatabaseSingleton? _instance;
		private static readonly object _lock = new();
		public string? Value { get; set; }
		private DatabaseSingleton()
		{

		}

		public static DatabaseSingleton GetInstance(string value)
		{
			if(_instance == null)
			{
				lock (_lock)
				{
                    if (_instance == null)
					{
                        _instance = new()
                        {
                            Value = value
                        };
                    }
				}
			}

			return _instance;
		}
    }
}

