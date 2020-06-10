using InterfaceAndAbstractClasses.Entities;
using System;

namespace InterfaceAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student()
            {
                Id = 123,
                Name = "Ognen",
                Password = 321,
                UserName = "OgnenTem",
                Grades = { 5, 5, 4, 3 }

            };
            studentOne.PrintUser();
            studentOne.ShowGrades();
            Console.WriteLine("------------------");

            Teacher teacherOne = new Teacher()
            {
                Id = 456,
                Name = "Goce",
                Subjects = { "HTML & CSS", "JavaScript", "C#", "C#-Advance" },
                UserName = "GoceKab"
            };
            teacherOne.PrintUser();
            teacherOne.ShowSubjects();
            Console.WriteLine("------------------");

            Assistant assistantOne = new Assistant()
            {
                Homeworks =
                {
                    {1,"HTML"},
                    {2,"CSS" },
                    {3,"JS" },
                    {4,"C#" }
                },
                Name = "Ivan",
                Id = 789,
                UserName = "IvanNez"
            };
            assistantOne.PrintUser();
            assistantOne.ShowHomeworksResult();


            Console.ReadLine();
        }
    }
}
