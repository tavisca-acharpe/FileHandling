using System.Collections.Generic;
using System.IO;

namespace FileHandling
{ 
        public class ReadFileContent
        {
            public  void ReadTextFile(string path, Dictionary<string, string> ContentDictionary)
            {
                string[] fileContent = File.ReadAllLines(path);
                string[] requestLine = fileContent[0].Split(' ');

                ContentDictionary.Add("version",requestLine[0]);
                ContentDictionary.Add("status code", requestLine[0]);
                ContentDictionary.Add("resone phrase", requestLine[0]);

                for (int i = 1; i < fileContent.Length-1; i++)
                {
                      string[] spliteLile = fileContent[i].Split(':');
                      ContentDictionary.Add(spliteLile[0], spliteLile[1]);
                }
                
            }     
         }  
}
