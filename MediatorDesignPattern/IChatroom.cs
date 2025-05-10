using System;
namespace MediatorDesignPattern
{
	public interface IChatroom
	{
		void RegisterUser(User user);
		void SendMessage(string from, string to, string msg);
	}
}

