using System;
namespace MomentoDesignPattern
{
	public class History
	{
		private Notepad _notepad;
		private Stack<MomentoSnapshot> _momentoSnapshots;
		public History(Notepad notepad)
		{
			_momentoSnapshots = new();
			_notepad = notepad;
		}

		public void AddSnapshot()
		{
			_momentoSnapshots.Push(_notepad.SaveState());
		}

		public void Undo()
		{
			if (_momentoSnapshots.Count > 0)
			{
				MomentoSnapshot momentoSnapshot = _momentoSnapshots.Pop();
				_notepad.Undo(momentoSnapshot);
				return;
			}

			Console.WriteLine("Nothing to Undo here");
		}

	}
}

