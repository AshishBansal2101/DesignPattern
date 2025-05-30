using System;
namespace MediatorDesignPattern
{
	public class User
	{
		public string Name { get; }
		private Chatroom? _chatroom;

		public User(string name)
		{
			Name = name;
			
		}

		public void SetchatRoom(Chatroom chatroom)
		{
			_chatroom = chatroom;
		}

		public void SendMessage(string to, string msg)
		{
			Console.WriteLine($"Sending msg {Name}");
			_chatroom?.SendMessage(Name,to,msg);
		}

		public void RecieveMessage(string from ,string msg)
		{
			Console.WriteLine("Msg Recieved by " + Name + "  from " + from+ "   "+ msg);

		}

	}
}

