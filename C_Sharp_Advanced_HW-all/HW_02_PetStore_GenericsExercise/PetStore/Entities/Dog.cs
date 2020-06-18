using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"This DOG is {Name}, {Type} - {Age} years old.");
        }
    }
}
