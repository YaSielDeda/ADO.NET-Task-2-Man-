using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Man(string name, int age, int weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nWeight: {2}\nHeight: {3}", Name, Age, Weight, Height);
        }
        public Student convertToStudent(int year, int course, int group)
        {
            return new Student(Name, Age, Weight, Height, year, course, group);
        }
    }
    class Student : Man
    {
        public int Year { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }

        public Student(string name, int age, int weight, int height, int year, int course, int group) : base(name, age, weight, height)
        {
            Year = year;
            Course = course;
            Group = group;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nWeight: {2}\nHeight: {3}\nYear: {4}\nCourse: {5}\nGroup: {6}", Name, Age, Weight, Height, Year, Course, Group);
        }
        public Man convertToMan()
        {
            return new Man(Name, Age, Weight, Height);
        }
    }
}
