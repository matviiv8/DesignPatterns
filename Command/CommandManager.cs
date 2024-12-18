﻿namespace Command
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count > 0)
            {
                ICommand command = _history.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }
    }
}
