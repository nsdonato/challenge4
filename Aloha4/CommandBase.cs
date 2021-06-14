using System;

namespace Aloha4
{
    public abstract class CommandBase : ICommand
    {
        protected readonly string _param;
        protected CommandBase(string param)
        {
            _param = param;
        }

        protected virtual string Parse()
        {
            return string.Empty;
        }

        protected abstract void InnerExecute();

        public void Execute()
        {
            var errors = this.Parse();
            if (errors == string.Empty)
            {
                this.InnerExecute();
            }
            else
            {
                Console.WriteLine(errors);
            }
        }
    }
}