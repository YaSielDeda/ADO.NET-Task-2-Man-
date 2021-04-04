using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    public class Student : Man
    {
        public int Year { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public Student() { }
        public Student(string name, int age, int weight, int height, int year, int course, int group) : base(name, age, weight, height)
        {
            Year = year;
            Course = course;
            Group = group;
        }
        public override string ToString()
        {
            return $"Name: {Name}" +
                $"{Environment.NewLine}Age: {Age}" +
                $"{Environment.NewLine}Weight: {Weight}" +
                $"{Environment.NewLine}Height: {Height}" +
                $"{Environment.NewLine}Year: {Year}" +
                $"{Environment.NewLine}Course: {Course}" +
                $"{Environment.NewLine}Group: {Group}";
        }
        public Man convertToMan()
        {
            return new Man(Name, Age, Weight, Height);
        }
    }
}
