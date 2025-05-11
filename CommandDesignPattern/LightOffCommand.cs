namespace CommandDesignPattern
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.LightOff();
        }

        public void Undo()
        {
            _light.LightOn();
        }
    }
}

