using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Man
{
    class StudentWorker
    {
        public Student GetStudent(string path)
        {
            var studentFileModel = GetStudentFromFile(path);
            var student = ParseStudent(studentFileModel);
            return student;
        }
        private StudentFileModel GetStudentFromFile(string path)
        {
            string[] StringsFromFile;
            StringsFromFile = File.ReadLines(path).ToArray();
            if (StringsFromFile.Length < 6)
            {
                throw new InvalidDataException("Lack of data! Some data may absent or written in one line");
            }
            return new StudentFileModel(
                StringsFromFile[0], 
                StringsFromFile[1], 
                StringsFromFile[2], 
                StringsFromFile[3], 
                StringsFromFile[4], 
                StringsFromFile[5], 
                StringsFromFile[6]
                );
        }
        private Student ParseStudent(StudentFileModel studentFileModel)
        {
            if (int.TryParse(studentFileModel.Name, out var _) ||
                !int.TryParse(studentFileModel.Age, out var _) ||
                !int.TryParse(studentFileModel.Height, out var _) ||
                !int.TryParse(studentFileModel.Weight, out var _) ||
                !int.TryParse(studentFileModel.Year, out var _) ||
                !int.TryParse(studentFileModel.Course, out var _) ||
                !int.TryParse(studentFileModel.Group, out var _))
            {
                throw new FormatException("You provided wrong type of data! Check file for this issues.");
            }
            return new Student(
                studentFileModel.Name,
                int.Parse(studentFileModel.Age),
                int.Parse(studentFileModel.Height),
                int.Parse(studentFileModel.Weight),
                int.Parse(studentFileModel.Year),
                int.Parse(studentFileModel.Course),
                int.Parse(studentFileModel.Group)
                );
        }
    }
}
