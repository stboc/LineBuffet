namespace LineBuffetLib
{
    public static class LineBuffet
    {
        public static void Analyse(IEnumerable<string> inputFiles, IEnumerable<string> searchPatterns, string outputPath)
        {
            var matchedLines = inputFiles
                .Select(FileAnalyzer.ReadLines)
                .Select(lines => LineAnalyzer.SearchPatterns(lines, searchPatterns))
                .SelectMany(line => line);

            FileAnalyzer.OutputLines(matchedLines, outputPath);
        }
    }
}