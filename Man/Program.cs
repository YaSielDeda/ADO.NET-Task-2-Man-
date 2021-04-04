using System;
using System.IO;

/*Вариант 2
Создать класс Man. Определить свойства для: имени, возраста, веса и роста. 
Создать производный класс Student, дополняющий  свойства: год начала обучения, курс и номер группы. 
Обеспечить нахождение класса в заведомо корректном состоянии.*/

namespace Man
{
    class Program
    {
        static void Main(string[] args)
        {
            string manPath = @"manInput.txt";
            string studentPath = @"studentInput.txt";

            Man man = createMan(manPath);
            Console.WriteLine(man);

            Console.WriteLine();

            Student student = createStudent(studentPath);
            Console.WriteLine(student);
        }
        public static Man createMan(string path)
        {
            ManWorker _manWorker = new ManWorker();
            Man man = null;
            try
            {
                man = _manWorker.GetMan(path);
            }
            catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            return man;
        }
        public static Student createStudent(string path)
        {
            StudentWorker _studentWorker = new StudentWorker();
            Student student = null;
            try
            {
                student = _studentWorker.GetStudent(path);
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            return student;
        }
    }
}
