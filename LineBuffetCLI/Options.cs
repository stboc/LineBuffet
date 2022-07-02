using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetCLI
{
    internal class Options
    {
        [Option('i', "input", Required = true, Separator = ',', HelpText = "検索対象のファイル")]
        public IEnumerable<string> InputFiles { get; set; } = new List<string>();

        [Option('p', "pattern", Required = true, Separator = ',', HelpText = "検索文字列")]
        public IEnumerable<string> SearchPatterns { get; set; } = new List<string>();

        [Option('o', "output", Required = false, HelpText = "出力ファイル")]
        public string OutputPath { get; set; } = "";
    }
}
