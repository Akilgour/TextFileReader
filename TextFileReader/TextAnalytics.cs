using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileReader
{
    public class TextAnalytics
    {
        public string OriginalText { get; private set; }

        public TextAnalytics(string text)
        {
            OriginalText = text;
        }

    }
}
