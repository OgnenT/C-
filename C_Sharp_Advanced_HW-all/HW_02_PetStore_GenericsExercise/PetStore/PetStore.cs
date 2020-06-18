using PetStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets;
        public PetStore()
        {
            ListOfPets = new List<T>();
        }

        public void PrintPets()
        {
            foreach (T pet in ListOfPets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string petName)
        {
            T insertedName = ListOfPets.FirstOrDefault(name => name.Name == petName);
            if (insertedName != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulation!! You bought your pet named {petName}.");
                ListOfPets.Remove(insertedName);
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry we do not have this pet, named {petName}. :(");
                Console.ResetColor();

            }
        }
        public void InsertPet(T pet)
        {
            ListOfPets.Add(pet);
        }
    }
}
