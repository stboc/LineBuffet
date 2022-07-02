using CommandLine;
using LineBuffetLib;

namespace LineBuffetCLI
{
    class Program
    {
        private enum ReturnCode : int
        {
            Succeeded,
            FailedToParseArguments,
        }

        public static int Main(string[] args)
        {
            var options = OptionsManager.ParseArguments(args);
            if (options == null)
            {
                return (int)ReturnCode.FailedToParseArguments;
            }

            LineBuffet.Analyse(options.InputFiles, options.SearchPatterns, options.OutputPath);

            return (int)ReturnCode.Succeeded;
        }
    }
}
