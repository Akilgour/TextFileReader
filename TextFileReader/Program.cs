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
            Console.WriteLine("Text From File");
            Console.WriteLine(textFromFile);

            var textAnalytics = new TextAnalytics(textFromFile);
            Console.WriteLine("Text that is being checked");
            Console.WriteLine(textAnalytics.OriginalText);


            Console.ReadKey();
        }
    }
}
