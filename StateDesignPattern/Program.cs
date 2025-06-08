namespace StateDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        IPhone phone = new Phone(new UnlockPhoneStatus());
        phone.PlugInCharger();
        phone.PressPowerButton();
        phone.PressPowerButton();

        phone.TransitionState(new LowBatteryPhoneStatus());
        phone.PressPowerButton();
        phone.PlugInCharger();
        phone.PressPowerButton();

        Console.ReadLine();
    }
}

