using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Man
{
    public class ManWorker
    {
        public Man GetMan(string path)
        {
            var manFileModel = GetManFromFile(path);
            var man = ParseMan(manFileModel);
            return man;
        }
        private ManFileModel GetManFromFile(string path)
        {
            string[] StringsFromFile;
            StringsFromFile = File.ReadLines(path).ToArray();
            if (StringsFromFile.Length < 3)
            {
                throw new InvalidDataException("Lack of data! Some data may absent or written in one line");
            }
            return new ManFileModel(StringsFromFile[0], StringsFromFile[1], StringsFromFile[2], StringsFromFile[3]);
        }
        private Man ParseMan(ManFileModel manFileModel)
        {
            if(  int.TryParse(manFileModel.Name, out var _) ||
                !int.TryParse(manFileModel.Age, out var _) ||
                !int.TryParse(manFileModel.Height, out var _) ||
                !int.TryParse(manFileModel.Weight, out var _))
            {
                throw new FormatException("You provided wrong type of data! Check file for this issues.");
            }
            return new Man(manFileModel.Name, int.Parse(manFileModel.Age), int.Parse(manFileModel.Height), int.Parse(manFileModel.Weight));
        }
    }
}
