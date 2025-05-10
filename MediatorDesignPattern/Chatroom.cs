using System;
namespace MediatorDesignPattern
{
	public class Chatroom : IChatroom
	{
        private readonly Dictionary<string, User> _users;
		public Chatroom()
		{
            _users = new();
		}

        public void RegisterUser(User user)
        {
            if (!_users.ContainsKey(user.Name))
            {
                _users[user.Name] = user;
                user.SetchatRoom(this);
                Console.WriteLine("user registered  " + user.Name);
            }
        }

        public void SendMessage(string from, string to, string msg)
        {
            if (_users.TryGetValue(to, out User? user))
            {
                Console.WriteLine("msg sent");
                user.RecieveMessage(from,msg);
            }
            else
            {
                Console.WriteLine("User  \"" + to + "\"  doesnt exist Can't Send Message");
            }
        }
    }
}

