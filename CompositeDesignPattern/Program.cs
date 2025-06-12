namespace CompositeDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        IEmployee jonEmp = new BaseEmployee("Jon", 20000);
        IEmployee rockEmp = new BaseEmployee("Rock", 10000);
        IEmployee  aladdinEmp = new BaseEmployee("Aladdin", 1000);
        IEmployee jasmine = new BaseEmployee("Jasmine", 20023);

        Manager tonyManager = new("Tony", 20030);
        Manager chrisManager = new("Chris", 100);

        Console.WriteLine("Salary of Aladdin: " + aladdinEmp.GetSalary());

        tonyManager.AddEmployee(jonEmp);
        tonyManager.AddEmployee(rockEmp);

        Console.WriteLine("Salaries total cost of tony manager employees: " + tonyManager.GetSalary());

        chrisManager.AddEmployee(aladdinEmp);
        chrisManager.AddEmployee(jasmine);

        Console.WriteLine("cost(total) by chris manager employee: " + chrisManager.GetSalary());

        Manager ceoFury = new("Nick", 10101);
        ceoFury.AddEmployee(tonyManager);
        ceoFury.AddEmployee(chrisManager);

        Console.WriteLine("Money burnt by CEO Fury: " + ceoFury.GetSalary());

        Console.ReadLine();

    }
}

