using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetLib.Test
{
    public class LineBuffetTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AnalysisTest()
        {
            var executeFilePath = Assembly.GetEntryAssembly().Location;
            var executeDir = Path.GetDirectoryName(executeFilePath);
            var testData = new List<string>
            {
                Path.Combine(executeDir, "TestData\\TestData01.txt"),
                Path.Combine(executeDir, "TestData\\TestData02.txt"),
            };

            var searchPattern = new List<string> { "い", "う" };
            var expectLines = "いきしちにひみいりい\nうくすつぬふむゆるう\nあいうえお\nやいゆえよ\nわいうえを\r\n";

            var outputPath = Path.Combine(executeDir, "TestData\\TestOutput.txt");

            LineBuffet.Analyse(testData, searchPattern, outputPath);

            var analysisResult = "";
            {
                using var reader = new StreamReader(outputPath);
                analysisResult = reader.ReadToEnd();
            }

            Assert.AreEqual(expectLines, analysisResult);
        }
    }
}
