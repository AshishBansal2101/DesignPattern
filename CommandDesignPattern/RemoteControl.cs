namespace CommandDesignPattern
{
	public class RemoteControl
	{
		private readonly Dictionary<string, ICommand> _buttons = new();
		private  ICommand? _lastCommand;

		public void SetCommand(string button, ICommand command)
		{
			if (!_buttons.TryAdd(button, command))
			{
				Console.WriteLine("Button already added");
			}
		}

		public void PressButton(string button)
		{
			if (_buttons.TryGetValue(button, out ICommand? value))
			{
                value.Execute();
				_lastCommand = value;
			}
			else
			{
				Console.WriteLine("No such button");
			}
		}

		public void UndoButton()
		{
			if(_lastCommand != null)
			{
				_lastCommand.Undo();
			}
			else
			{
				Console.WriteLine("Press an button first before undo");
			}
		}
	}
}

