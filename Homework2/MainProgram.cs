using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            TextFileReader txtImporter = new TextFileReader();
            Console.WriteLine("파일 주소를 입력해주세요");
            string filePath = Console.ReadLine();
            Console.WriteLine("\n");
            string[] textFile = txtImporter.txtImport(filePath);
        }
    }
}

