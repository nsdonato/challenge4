using System;

namespace Aloha4
{
    internal class PwdCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        }
    }
}