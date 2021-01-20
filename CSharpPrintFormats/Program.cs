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
            var i = 1234;
            var j = 5576788;
            var i2 = 8;
            Console.WriteLine($"{i,5}|{j}");
            Console.WriteLine($"{i2,5}|{j}");
        }
    }
}
