using InterfaceAndAbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractClasses.Entities
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public void PrintUser()
        {
            Console.WriteLine($"I am {Name} with ID: {Id} and UserName: {UserName}");
        }
    }
}
