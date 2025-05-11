namespace CommandDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            Light light = new();
            LightOnCommand lightOnCommand = new(light);
            LightOffCommand lightOffCommand = new(light);

            RemoteControl remoteControl = new();

            remoteControl.SetCommand("A", lightOnCommand);
            remoteControl.SetCommand("B", lightOffCommand);

            remoteControl.PressButton("A");
            remoteControl.UndoButton();

            remoteControl.PressButton("A");
            remoteControl.PressButton("B");
            remoteControl.UndoButton();

            Console.ReadKey();
        }
    }
}

