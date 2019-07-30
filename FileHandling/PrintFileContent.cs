using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    class PrintFileContent
    {
        public void DisplayFileContent(Dictionary<string, string> Information)
        {
           foreach(string key in Information.Keys )
            {
                Console.WriteLine(key+" : "+ Information[key]);
            }
        }
    }
}
