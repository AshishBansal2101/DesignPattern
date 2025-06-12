using System;
namespace MomentoDesignPattern
{
	public class Notepad
	{
		private string _content;
		public Notepad(string content)
		{
			_content = content;
		}

		public void Add(string word)
		{
			_content += "   " + word;
			Console.WriteLine("Adding ..." + word);
		}

		public MomentoSnapshot SaveState()
		{
			Console.WriteLine("Saving this state as snapshot when content is ..." + _content);
			return new MomentoSnapshot(_content);
		}

		public void Undo(MomentoSnapshot momento)
		{
			_content = momento.GetContent();
			Console.WriteLine("Undo the state making it ...." + _content);
		}
	}
}

