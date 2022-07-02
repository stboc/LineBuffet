using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBuffetLib
{
    internal class LineAnalyzer
    {
        internal static IEnumerable<string> SearchPatterns(string lines, IEnumerable<string> searchPatterns) =>
            lines.Split(new[] { '\r', '\n' })
                .Where(line => searchPatterns.Any(pattern => line.Contains(pattern)));

    }
}
