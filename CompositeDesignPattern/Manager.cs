using System;
namespace CompositeDesignPattern
{
	public class Manager : IEmployee
	{
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<IEmployee> employees = new List<IEmployee>();
        public Manager(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
        public int GetSalary()
        {
            int total = Salary;

            foreach (IEmployee employee in employees)
            {
                total += employee.GetSalary();
            }

            return total;
        }
    }
}

