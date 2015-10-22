using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFileReader
{
    public class TextAnalytics
    {
        public string OriginalText { get; private set; }
        public string TextWithoutTabAndSpaceRemoved { get; private set; }

        public TextAnalytics(string text)
        {
            OriginalText = text;
            //This regex will strip out all tabs and spaces.
            TextWithoutTabAndSpaceRemoved = Regex.Replace(OriginalText, @"\t| ", "");
        }

        public int CharCount()
        {
            return TextWithoutTabAndSpaceRemoved.Length;
        }

        public Dictionary<char, int> TenMostFrequentChar()
        {
            var charDictionary = new  Dictionary<char, int>();

            foreach (var x in TextWithoutTabAndSpaceRemoved)
            {
                if (charDictionary.ContainsKey(x))
                {
                    charDictionary[x] = charDictionary[x]+1;
                }
                else
                {
                    charDictionary.Add(x, 1);
                }
            }
            return charDictionary;
        }
    }
}
