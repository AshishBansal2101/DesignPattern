namespace ObserverDesignPattern
{
	public class SmartHome : ISubscriber
	{
		public SmartHome()
		{
		}

        public void update(string temp)
        {
            Console.WriteLine($"Temp is set to {temp} currently in your smart home device");
        }
    }
}

