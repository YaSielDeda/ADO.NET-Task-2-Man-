using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Man
{
    public class ManWorker
    {
        public static int ManMustHaveStrings = 4;
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
            if (StringsFromFile.Length != ManMustHaveStrings)
            {
                throw new InvalidDataException("Lack of data! Some data may absent or written in one line");
            }
            return new ManFileModel(StringsFromFile[0], StringsFromFile[1], StringsFromFile[2], StringsFromFile[3]);
        }
        private Man ParseMan(ManFileModel manFileModel)
        {
            if(  Validation(manFileModel.Name) != true ||
                !int.TryParse(manFileModel.Age, out var age) ||
                !int.TryParse(manFileModel.Height, out var height) ||
                !int.TryParse(manFileModel.Weight, out var weight))
            {
                throw new FormatException("You provided wrong type of data! Check file for this issues.");
            }
            return new Man(manFileModel.Name, age, height, weight);
        }
        private bool Validation(string name)
        {
            if (int.TryParse(name, out var _))
                return false;

            char[] ViolatedSymbols = new char[] { '.', ',', '!', '@', '#', '№', '$', ';', '%', '^', ':', '&', '?', '*', '(', ')', '-', '_', '=', '+'};

            foreach (var s in ViolatedSymbols)
            {
                if (name.Contains(s))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
