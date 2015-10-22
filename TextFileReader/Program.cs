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
            if (TextFileHelpers.FileExists(filePath))
            {
                var textFromFile = TextFileHelpers.ReadTextFileToString(filePath);

                var textAnalytics = new TextAnalytics(textFromFile);
                Console.WriteLine("Text that is being checked");
                Console.WriteLine(textAnalytics.OriginalText);
                Console.WriteLine(string.Format("Total characters : {0}", textAnalytics.CharCount()));

                var charDictionary = textAnalytics.TenMostFrequentChar();
                Console.WriteLine("Ten most frequent characters.");
                foreach (var x in charDictionary)
                {
                    Console.WriteLine(string.Format("{0} ({1})", x.Key, x.Value));
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
            Console.ReadKey();
        }
    }
}
