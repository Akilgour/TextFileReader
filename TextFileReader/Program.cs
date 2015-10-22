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
            Console.WriteLine("Please Enter File Path, then press Enter.");
            var filePath = Console.ReadLine();
            //TODO Add check if file exists
            var textFromFile = TextFileHelpers.ReadTextFileToString(filePath);
            Console.WriteLine(textFromFile);
            Console.ReadKey();
        }
    }
}
