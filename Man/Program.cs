using System;
using System.IO;
using static Man.Exceptions;

/*Вариант 2
Создать класс Man. Определить свойства для: имени, возраста, веса и роста. 
Создать производный класс Student, дополняющий  свойства: год начала обучения, курс и номер группы. 
Обеспечить нахождение класса в заведомо корректном состоянии.*/

namespace Man
{
    class Program
    {
        static FileWorker worker = new FileWorker();
        public static Man createMan(string path)
        {
            Man man;

            try
            {
                string[] temp = worker.Load(path);
                man = new Man(temp[0], int.Parse(temp[1]), int.Parse(temp[2]), int.Parse(temp[3]));
            }
            catch(LackOfData)
            {
                man = new Man();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Lack of data! Some data may absent or written in one line");
                Console.ResetColor();
            }
            catch (FormatException e)
            {
                man = new Man();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

            return man;
        }
        public static Student createStudent(string path)
        {
            Student student;

            try
            {
                string[] temp = worker.Load(path);
                student = new Student(temp[0], int.Parse(temp[1]), int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[4]), int.Parse(temp[5]), int.Parse(temp[6]));
            }
            catch (LackOfData)
            {
                student = new Student();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Lack of data! Some data may absent or written in one line");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                student = new Student();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Format exception! It's seems that you write data incorrectly, check the format and try again");
                Console.ResetColor();
            }

            return student;
        }
        static void Main(string[] args)
        {
            string manPath = @"manInput.txt";
            string studentPath = @"studentInput.txt";

            Man man = createMan(manPath);
            Console.WriteLine(man.ToString());

            Console.WriteLine();

            Student student = createStudent(studentPath);
            Console.WriteLine(student.ToString());
        }
    }
}
