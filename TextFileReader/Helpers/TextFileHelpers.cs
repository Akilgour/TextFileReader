using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileReader.Helpers
{
    public static class TextFileHelpers
    {
        public static string ReadTextFileToString(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\text.txt");
            while ((line = file.ReadLine()) != null)
            { 
                sb.Append(line);
            }
            file.Close();
            return sb.ToString();
        }
    }
}
