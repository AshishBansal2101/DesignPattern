namespace ObserverDesignPattern
{
	public class MobileDevice : ISubscriber
	{
		private string _name;
		public MobileDevice(string name)
		{
			_name = name;
		}

		public void update(string temp)
        {
			Console.WriteLine($"Temp is set to {temp} currently in device {_name}");
        }
    }
}

