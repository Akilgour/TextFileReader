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
        public string TextWithTabAndSpaceRemoved { get; private set; }

        public TextAnalytics(string text)
        {
            OriginalText = text;
        }

        public int CharCount()
        {
            //This regex will strip out all tabs and spaces.
            string TextWithTabAndSpaceRemoved = Regex.Replace(OriginalText, @"\t| ", "");
            return TextWithTabAndSpaceRemoved.Length;
        }

    }
}
