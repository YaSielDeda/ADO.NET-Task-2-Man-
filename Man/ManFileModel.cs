using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    public class ManFileModel
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }

        public ManFileModel(string name, string age, string weight, string height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
    }
}
