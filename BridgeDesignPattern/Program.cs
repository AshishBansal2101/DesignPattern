namespace BridgeDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        IDevice tv = new Television();
        BasicRemote TvBasicRemote = new(tv);
        TvBasicRemote.ToggleSwitch();
        TvBasicRemote.UpVolume();
        TvBasicRemote.DownVolume();
        TvBasicRemote.SetChannel(201);
        TvBasicRemote.ToggleSwitch();

        Console.WriteLine(".....................");

        IDevice radio = new Radio();
        AdvanceRemote advanceRemote = new (radio);

        advanceRemote.ToggleSwitch();
        advanceRemote.SetChannel(10001);
        advanceRemote.Mute();
        advanceRemote.ToggleSwitch();


        Console.WriteLine();


    }
}

