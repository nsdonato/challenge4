using System;

namespace Aloha4
{
    internal class ListCommand : CommandBase
    {
        bool _isRecursive = false;

        public ListCommand(string param) : base(param)
        {

        }

        protected override string Parse()
        {
            if (!string.IsNullOrWhiteSpace(_param) && _param.Length >= 1 && _param.Contains("-r"))
            {
                _isRecursive = true;
            }

            return string.Empty;
        }

        protected override void InnerExecute()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            var files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), string.Empty, _isRecursive ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}