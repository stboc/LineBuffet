using NUnit.Framework;
using System.Collections.Generic;

namespace LineBuffetLib.Test
{
    public class LineAnalyzerTest
    {
        private static readonly string InputLines = @"aiueo
kakikukeko
sasisuseso
tatituteto
akasatana
ikisitini
ukusutunu";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SearchPatternsTest()
        {
            var searchPatterns = new List<string>()
            {
                "ka", "ku"
            };

            var expectation = new List<string>()
            {
                "kakikukeko",
                "akasatana",
                "ukusutunu",
            };

            var searchResult = LineAnalyzer.SearchPatterns(InputLines, searchPatterns);
            Assert.AreEqual(expectation, searchResult);
        }
    }
}