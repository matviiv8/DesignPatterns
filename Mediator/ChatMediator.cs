namespace Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender.Name);
                }
            }
        }
    }
}
