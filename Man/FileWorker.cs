using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Man.Exceptions;

namespace Man
{
    class FileWorker
    {
        string path = @"input.txt";
        string[] rawData;
        public string[] Load()
        {
            try
            {
                rawData = File.ReadAllText(path).Split('\n');
            }
            catch(FileNotFoundException)
            {
                throw new Exception("File is missing!");
            }
            if (rawData.Length < 3)
            {
                throw new LackOfData("Lack of data! Some data may absent or written in one line");
            }
            return rawData;
        }
    }
}
