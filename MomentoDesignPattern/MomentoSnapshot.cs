using System;
namespace MomentoDesignPattern
{
	public class MomentoSnapshot
	{
		private readonly string _content;
		public MomentoSnapshot(string content)
		{
			_content = content;
		}

		public string GetContent()
		{
			return _content;
		}
	}
}

