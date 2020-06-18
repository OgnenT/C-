using PetStore.Entities;
using System;

namespace PetStore
{
    class Program
    {

        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();

        static void Main(string[] args)
        {

            Dog dog1 = new Dog() { Name = "Asi", Age = 3, Type = "Beagle" };
            Dog dog2 = new Dog() { Name = "Apis", Age = 7, Type = "Bulldog" };
            Dog dog3 = new Dog() { Name = "Asi", Age = 2, Type = "Boxer" };

            DogStore.InsertPet(dog1);
            DogStore.InsertPet(dog2);
            DogStore.InsertPet(dog3);

            DogStore.PrintPets();
            Console.WriteLine("--------------------------------------------------------");

            Cat cat1 = new Cat() { Name = "Aja", Age = 8, Type = "Persian", IsLazy = true, LivesLeft = 1 };
            Cat cat2 = new Cat() { Name = "Masha", Age = 2, Type = "Syamese", IsLazy = false, LivesLeft = 7 };
            Cat cat3 = new Cat() { Name = "Maza", Age = 3, Type = "Russian", IsLazy = true, LivesLeft = 6 };

            CatStore.InsertPet(cat1);
            CatStore.InsertPet(cat2);
            CatStore.InsertPet(cat3);

            CatStore.PrintPets();
            Console.WriteLine("--------------------------------------------------------");

            Fish fish1 = new Fish() { Name = "Nemo", Type = "Goldfish", Age = 1, Color = "Yellow", Size = 12 };
            Fish fish2 = new Fish() { Name = "Jack", Type = "Carp", Age = 2, Color = "Green", Size = 22 };
            Fish fish3 = new Fish() { Name = "Moby", Type = "Bluetang", Age = 4, Color = "Blue", Size = 10 };

            FishStore.InsertPet(fish1);
            FishStore.InsertPet(fish2);
            FishStore.InsertPet(fish3);

            FishStore.PrintPets();

            Console.WriteLine("---------------------------------------------------------");
            string dogsNameForBuying = "Asi";
            DogStore.BuyPet(dogsNameForBuying);
            DogStore.PrintPets();

            Console.WriteLine("---------------------------------------------------------");
            string catsNameForBuying = "Noname";
            CatStore.BuyPet(catsNameForBuying);
            CatStore.PrintPets();
            Console.ReadLine();
        }
    }
}
