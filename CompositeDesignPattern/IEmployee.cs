using System;
namespace CompositeDesignPattern
{
	public interface IEmployee
	{
		public string Name { get; set; }
        public int Salary { get; set; }
		public int GetSalary();
    }
}

