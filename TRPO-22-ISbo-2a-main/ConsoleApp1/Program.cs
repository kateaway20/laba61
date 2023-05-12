using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Пара": UI.Print(ClassCreator.Para()); break;
                    case "Подразделение": UI.Print(ClassCreator.Division()); break;
                    case "Должность": UI.Print(ClassCreator.Salary()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Discipline()); break;
                    case "Студент": UI.Print(ClassCreator.Student());break;
                    case "Смена": UI.Print(ClassCreator.Smena());break;
                    case "Сотрудник": UI.Print(ClassCreator.Employee()); break;
                    case "Аудитория": UI.Print(ClassCreator.Auditoria()); break;
                    case "Занятие": UI.Print(ClassCreator.Lesson()); break;
                    case "Специальность": UI.Print(ClassCreator.Specialization()); break;
                    case "Группа": UI.Print(ClassCreator.Group()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
