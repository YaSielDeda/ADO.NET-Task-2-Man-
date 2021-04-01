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
            Man Ivan = new Man("Ivan", 25, 65, 180);
            Console.WriteLine(Ivan.ToString());
            FileWorker worker = new FileWorker();
            worker.Load();
            Student student = Ivan.convertToStudent(2012, 2, 251);
            Console.WriteLine(student.ToString());
        }
    }
}
