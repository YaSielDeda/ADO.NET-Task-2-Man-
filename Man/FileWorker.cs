using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Man.Exceptions;

namespace Man
{
    class FileWorker
    {
        string[] rawData;
        public string[] Load(string path)
        {
            bool isInt;
            int res;
            try
            {
                rawData = File.ReadAllText(path).Split('\n');
                isInt = Int32.TryParse(rawData[0], out res);
            }
            catch(FileNotFoundException)
            {
                throw new Exception("File is missing!");
            }
            if (rawData.Length < 3)
            {
                throw new LackOfData("Lack of data! Some data may absent or written in one line");
            }
            if (isInt)
            {
                throw new FormatException("Name can't be a number!");
            }
            return rawData;
        }
    }
}
