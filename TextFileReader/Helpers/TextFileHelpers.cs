using System;
using System.Collections.Generic;
using System.IO;
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
            StreamReader file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            { 
                sb.Append(line);
            }
            file.Close();
            return sb.ToString();
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
