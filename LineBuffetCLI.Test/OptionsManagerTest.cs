using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineBuffetCLI;
using NUnit.Framework;

namespace LineBuffetCLI.Test
{
    internal partial class OptionsManagerTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ParseArguments_Normally()
        {
            var args  = new List<string>()
            {
                "-i", "filePath01,filePath02",
                "-p", "pattern01,pattern02",
            };

            var expectFilePaths = new List<string>() { "filePath01", "filePath02" };
            var expectSearchPatterns = new List<string>() { "pattern01", "pattern02" };
            var expectOutputPath = "";

            var parseresult = OptionsManager.ParseArguments(args);
            Assert.IsNotNull(parseresult);
            ExceptOptions(parseresult, expectFilePaths, expectSearchPatterns, expectOutputPath);
        }

    }
}
