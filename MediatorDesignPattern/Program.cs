namespace MediatorDesignPattern.Program
{
    public class Program
    {
        public static void Main()
        {
            User u1 = new ("Alice");
            User u2 = new ("Bob");

            Chatroom chatroom = new();
            chatroom.RegisterUser(u1);
            chatroom.RegisterUser(u2);

            u1.SendMessage("Bob", "Hey how are you broo");
            u2.SendMessage("Alice", "I am doing great.. What about you??");
            u1.SendMessage("NoUser", "Same bro.. everything is good");

            Console.ReadKey();
        }
    }
}