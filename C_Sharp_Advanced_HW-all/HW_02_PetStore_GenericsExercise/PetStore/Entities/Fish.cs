using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"This FISH is {Name}, {Type} - {Age} years old.");
        }
    }
}
