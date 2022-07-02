using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetLib
{
    internal static class FileAnalyzer
    {
        internal static string ReadLines(string inputFile)
        {
            try
            {
                using var reader = new StreamReader(inputFile);
                return reader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to read {inputFile} \n{e}");
                return "";
            }
        }

        internal static void OutputLines(string outputLines, string outputPath)
        {
            try
            {
                using var writer = new StreamWriter(outputPath);
                writer.WriteLine(outputLines);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to write to {outputPath} \n{e}");
            }
        }

        internal static void OutputLines(IEnumerable<string> outputLines, string outputPath)
        {
            OutputLines(string.Join("\n", outputLines), outputPath);
        }
    }
}
