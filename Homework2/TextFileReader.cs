using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class TextFileReader
    {
        public string[] txtImport(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                string[] textValue = System.IO.File.ReadAllLines(filePath);
                return textValue;
            }
            else
            {
                Console.WriteLine("File not found.");
                return null;
            }
        }
    }
}