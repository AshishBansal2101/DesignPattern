namespace ProxyDesignPattern
{
	public class Client
	{
		private readonly ISubject _subject;
		public Client(ISubject subject)
		{
			_subject = subject;
		}

		public void Process()
		{
			_subject.Request();
		}
	}
}

