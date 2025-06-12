using System;
namespace CompositeDesignPattern
{
	public class BaseEmployee : IEmployee
    { 
        public string Name { get; set; }
        public int Salary { get; set; }
	
		public BaseEmployee(string name, int salary)
		{
            Name = name;
            Salary = salary;
		}

        public int GetSalary()
        {
            return Salary;
        }
    }
}

