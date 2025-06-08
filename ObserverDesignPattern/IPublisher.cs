namespace ObserverDesignPattern
{
	public interface IPublisher
	{
		void SetTemperature(string temp);
		void Notify();
		void AddSubscriber(ISubscriber subscriber);
		void RemoveSubscriber(ISubscriber subscriber);
	}
}

