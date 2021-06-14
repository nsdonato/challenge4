namespace Aloha4
{
    internal class ChangeDirectoryCommand : CommandBase
    {
        bool _isGoBack = false;
        string _directory;

        public ChangeDirectoryCommand(string param) : base(param)
        {

        }

        protected override string Parse()
        {
            if (_param.Length < 1)
            {
                return "Invalid command";
            }

            _directory = _param;
            if (_directory == "..")
            {
                _isGoBack = true;
                return string.Empty;
            }
            else
            {
                if (!System.IO.Directory.Exists(_directory))
                {
                    return "Directory not found";
                }

                return string.Empty;
            }
        }

        protected override void InnerExecute()
        {
            if (_isGoBack)
            {
                var parent = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName;
                System.IO.Directory.SetCurrentDirectory(parent);
            }

            System.IO.Directory.SetCurrentDirectory(_directory);
        }
    }
}