namespace MomentoDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        Notepad notepad = new("Start");
        History history = new(notepad);

        notepad.Add("This is starting");
        history.AddSnapshot();

        notepad.Add("Completed MomentoPattern");

        history.AddSnapshot();

        notepad.Add("This is after 1st Snapshot");
        notepad.Add("Lets see what will happen now... Looking forward to it");


        history.AddSnapshot();

        notepad.Add("Second Snapshot Successfully added");

        history.Undo();
        history.Undo();
        history.Undo();
        history.Undo();

        Console.WriteLine();
        Console.ReadLine();

    }
}

