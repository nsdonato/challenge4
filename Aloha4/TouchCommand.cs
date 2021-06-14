namespace Aloha4
{
    internal class TouchCommand : CommandBase
    {
        string fileName = string.Empty;
        public TouchCommand(string command) : base(command)
        {

        }

        protected override string Parse()
        {
            if (_param.Length < 1)
            {
                return "Invalid command";
            }

            fileName = _param;
            return string.Empty;
        }

        protected override void InnerExecute()
        {
            string[] emptyFile = { "" };
            System.IO.File.WriteAllLinesAsync($"{fileName}.txt", emptyFile);
        }
    }
}