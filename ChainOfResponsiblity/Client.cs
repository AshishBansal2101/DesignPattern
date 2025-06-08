using System;
namespace ChainOfResponsiblity
{
	public class Client
	{
		private List<string> _requests;
		private ISupportHandler _handler;

		public Client(ISupportHandler handler) {
			_handler = handler;
			_requests = new();
		}

		public void AddRequest(string request)
		{
			_requests.Add(request);
		}

		public void HandleRequets()
		{
			foreach(string req in _requests)
			{
				Console.WriteLine($"Processing request :::: {req}\n\n");
				Console.WriteLine(_handler.Handle(req));
				Console.WriteLine("..................\n");
			}
		}

	}
}

