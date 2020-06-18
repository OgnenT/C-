using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractClasses.Entities
{
    public class Teacher : User, iTeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();
        public void ShowSubjects()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
