using System;
namespace CommandDesignPattern
{
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}

