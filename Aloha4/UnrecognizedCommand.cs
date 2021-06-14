using System;

namespace Aloha4
{
    internal class UnrecognizedCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Unrecognized command");
        }
    }
}