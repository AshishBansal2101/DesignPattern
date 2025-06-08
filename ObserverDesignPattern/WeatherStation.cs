using System;
namespace ObserverDesignPattern
{
	public class WeatherStation : IPublisher
	{
        private List<ISubscriber> _subscribers;
        private string _temp;

		public WeatherStation()
		{
            _subscribers = new();
            _temp = "21";
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Notify()
        {
            foreach(var subscriber in _subscribers)
            {
                subscriber.update(_temp);
            }
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void SetTemperature(string temp)
        {
            _temp = temp;
            Notify();
        }
    }
}

