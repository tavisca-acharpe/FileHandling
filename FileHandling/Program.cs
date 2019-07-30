using System;
using System.Collections.Generic;

namespace FileHandling
{
    class FileHandling
    {
        public static Dictionary<string, string> information = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            ReadFileContent read = new ReadFileContent();
            PrintFileContent print = new PrintFileContent();

            var path = "C:/Users/acharpe/Desktop/RequestFile.txt";
            read.ReadTextFile(path,information);

            print.DisplayFileContent(information );
        }       
    }  
}
    