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
        public string TextWithoutTabAndSpace { get; private set; }

        public TextAnalytics(string text)
        {
            OriginalText = text;
            //This regex will strip out all tabs and spaces.
            TextWithoutTabAndSpace = Regex.Replace(OriginalText, @"\t| ", "");
        }

        /// <summary>
        /// Will Count the number of unique characters  
        /// </summary>
        /// <returns></returns>
        public int CharCount()
        {
            return TextWithoutTabAndSpace.Length;
        }

        public Dictionary<char, int> TenMostFrequentCharUsingCase()
        {
            return TenMostFrequentChar(TextWithoutTabAndSpace);
        }
            
        public Dictionary<char, int> TenMostFrequentCharIgnoreCase()
        {
            return TenMostFrequentChar(TextWithoutTabAndSpace.ToLower());
        }

        private Dictionary<char, int> TenMostFrequentChar(string value)
        {
            var charDictionary = new Dictionary<char, int>();

            foreach (var x in value)
            {
                if (charDictionary.ContainsKey(x))
                {
                    charDictionary[x] = charDictionary[x] + 1;
                }
                else
                {
                    charDictionary.Add(x, 1);
                }
            }

            //This will order the Dictionary by the values
            charDictionary = charDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            if (charDictionary.Count < 10)
            {
                return charDictionary;
            }
            else
            {
                return charDictionary.Take(10).ToDictionary(x => x.Key, x => x.Value);
            }
        }

    }
}
