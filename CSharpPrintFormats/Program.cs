using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace CSharpPrintFormats
{
    class Program
    {
        private static void Main()
        {
            var i = 123;
            Console.WriteLine($"{i,10:D4}");
        }
    }
}
