using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Man
{
    public class StudentWorker
    {
        public static int StudentMustHaveStrings = 7;
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
            if (StringsFromFile.Length != StudentMustHaveStrings)
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
                !int.TryParse(studentFileModel.Age, out int age) ||
                !int.TryParse(studentFileModel.Height, out int height) ||
                !int.TryParse(studentFileModel.Weight, out int weight) ||
                !int.TryParse(studentFileModel.Year, out int year) ||
                !int.TryParse(studentFileModel.Course, out int course) ||
                !int.TryParse(studentFileModel.Group, out int group))
            {
                throw new FormatException("You provided wrong type of data! Check file for this issues.");
            }
            return new Student(
                studentFileModel.Name,
                age,
                height,
                weight,
                year,
                course,
                group
                );
        }
    }
}
