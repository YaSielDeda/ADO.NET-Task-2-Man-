using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    class StudentFileModel : ManFileModel
    {
        public string Year { get; set; }
        public string Course { get; set; }
        public string Group { get; set; }

        public StudentFileModel(string name, string age, string weight, string height, string year, string course, string group): base(name, age, weight, height)
        {
            Year = year;
            Course = course;
            Group = group;
        }
    }
}
