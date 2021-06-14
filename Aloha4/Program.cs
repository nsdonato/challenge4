using System;

namespace Aloha4
{
    class Program
    {
        static void Main(string[] args)
        {
            string _command;
            do
            {
                string _param = string.Empty;
                string[] _parseCommand;

                _command = Console.ReadLine();
                _parseCommand = _command.Split(" ");
                _command = _parseCommand[0];

                if (_parseCommand.Length > 1)
                {
                    _param = _parseCommand?[1];
                }

                ICommand cmd = CommandFactory.GetCommand(_command, _param);

                if (cmd != null)
                {
                    cmd.Execute();
                }

            } while (_command != "quit");
        }
    }
}
