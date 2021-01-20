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
            var i = 9876123;
            Console.WriteLine($"{i:n0}");

            var d = 9876123.45;
            Console.WriteLine($"{d:n}");

            decimal money = 123456789.453M;
            Console.WriteLine($"{money:n}");
            Console.WriteLine($"{money:n0}");
            Console.WriteLine($"{money:n5}");
        }
    }
}
