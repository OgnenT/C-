using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"This CAT is {Name}, {Type} - {Age} years old. {AdditionalInfo()}");
        }
        internal string AdditionalInfo()
        {
            return $"This cat is lazy-{IsLazy} and have {LivesLeft} lives left.";
        }
    }
}
