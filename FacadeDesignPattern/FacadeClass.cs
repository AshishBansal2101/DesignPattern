using System;
namespace FacadeDesignPattern
{
	public class FacadeClass
	{
		protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;


        public FacadeClass(Subsystem1 subsystem1, Subsystem2 subsystem2)
		{
			_subsystem1 = subsystem1;
			_subsystem2 = subsystem2;
		}

		public string Operation()
		{
			string result = "Starting some operation     ...   ";

			result += _subsystem1.operation1();
			result += _subsystem2.operation1();

			result += "operation 1 done  ..<><><><>...";

			result += _subsystem1.operationN();
			result += _subsystem2.operationZ();

			return result;
		}
	}
}

