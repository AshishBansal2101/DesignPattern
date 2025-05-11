namespace CommandDesignPattern
{
	public class LightOnCommand : ICommand
	{
		private readonly Light _light;
		public LightOnCommand(Light light)
		{
			_light = light;
		}
		public void Execute()
		{
			_light.LightOn();
		}

		public void Undo()
		{
			_light.LightOff();
		}
	}
}

