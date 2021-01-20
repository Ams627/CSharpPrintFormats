using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace CSharpPrintFormats
{
    class Program
    {
        private static void Main()
        {
            var d = 123456.789;
            FormattableString fs = $"{d:n3}";

            // create some cultures:
            var cultureStrings = new[] {"en-GB", "fr-FR", "cs-cz", "de-DE"}.ToList();
            var cultures = cultureStrings.Select(x => new CultureInfo(x)).ToList();
            cultures.ForEach(x => Console.WriteLine($"{fs.ToString(x)} - [{x.DisplayName}]"));
        }
    }
}
