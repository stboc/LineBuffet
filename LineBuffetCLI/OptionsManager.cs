using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetCLI
{
    internal class OptionsManager
    {
        public static Options? ParseArguments(IEnumerable<string> args)
        {
            var ret = new Options();
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(opt => ret = opt)
                .WithNotParsed(opt => ret = null);
            return ret;
        }

    }
}
