using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Man() { }

        public Man(string name, int age, int weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}Age: {Age}{Environment.NewLine}Weight: {Weight}{Environment.NewLine}Height: {Height}";
        }
        public Student convertToStudent(int year, int course, int group)
        {
            return new Student(Name, Age, Weight, Height, year, course, group);
        }
    }
}
