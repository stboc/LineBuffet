using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetCLI.Test
{
    internal partial class OptionsManagerTest
    {
        private void ExceptOptions(Options options, IEnumerable<string> inputFiles, IEnumerable<string> searchPatterns, string outputPath = "")
        {
            Assert.AreEqual(inputFiles.Count(), options.InputFiles.Count());
            foreach (var (index, item) in inputFiles.Select((item, index) => (index, item)))
            {
                Assert.AreEqual(item, options.InputFiles.ElementAt(index));
            }

            Assert.AreEqual(searchPatterns.Count(), options.SearchPatterns.Count());
            foreach (var (index, item) in searchPatterns.Select((item, index) => (index, item)))
            {
                Assert.AreEqual(item, options.SearchPatterns.ElementAt(index));
            }

            Assert.AreEqual(outputPath, options.OutputPath);
        }


    }
}
