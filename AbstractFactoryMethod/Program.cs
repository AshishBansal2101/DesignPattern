namespace AbstractFactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        IFactory teslaFactory = new TeslaFactory();
        Car eCar = new Car(teslaFactory);
        eCar.Build();

        Console.WriteLine("..........");

        IFactory toyataFactory = new ToyotaFactory();
        Car petrolCar = new Car(toyataFactory);
        petrolCar.Build();

        Console.ReadKey();
    }
}

