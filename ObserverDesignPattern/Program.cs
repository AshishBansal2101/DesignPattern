namespace ObserverDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        IPublisher weatherStation = new WeatherStation();
        ISubscriber iPhone = new MobileDevice("IPhone");
        ISubscriber samsung = new MobileDevice("Samsung");
        ISubscriber smartHome = new SmartHome();

        weatherStation.AddSubscriber(iPhone);
        weatherStation.AddSubscriber(samsung);
        weatherStation.AddSubscriber(smartHome);


        weatherStation.SetTemperature("37");

        weatherStation.RemoveSubscriber(iPhone);

        weatherStation.SetTemperature("-3");

        Console.ReadLine();

    }
}

