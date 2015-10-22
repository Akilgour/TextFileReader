using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileReader.Helpers;

namespace TextFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "foo";
            var textFromFile = TextFileHelpers.ReadTextFileToString(path);
          
            Console.WriteLine(textFromFile);
           
            Console.ReadKey();
        }
    }
}
