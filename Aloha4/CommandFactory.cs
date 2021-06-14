using System.Collections.Generic;

namespace Aloha4
{
    public static class CommandFactory
    {
        public static ICommand GetCommand(string command, string _param)
        {
            Dictionary<string, ICommand> availableCommands = new Dictionary<string, ICommand>()
            {
                { "pwd", new PwdCommand() },
                { "ls", new ListCommand(_param) },
                { "cd", new ChangeDirectoryCommand(_param) },
                { "touch", new TouchCommand(_param) },
                { "quit", new QuitCommand() },
            };

            foreach (var cmd in availableCommands)
            {
                if (command.ToLower() == cmd.Key)
                {
                    return cmd.Value;
                }
            }

            return new UnrecognizedCommand();
        }
    }
}
