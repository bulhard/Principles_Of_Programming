using Lesson_06_PetShop.Core;
using Lesson_06_PetShop.Entities;
using Lesson_06_PetShop.Enums;
using System;

namespace Lesson_06_PetShop
{
    class Program
    {

        static void Main(string[] args)
        {
            PetShop petShop = new PetShop(20);
            petShop.GeneratePets();

            while (true)
            {
                DisplayMenu();

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddPet(petShop);
                        break;

                    case "2":
                        SellPet(petShop);
                        break;

                    case "3":
                        ViewPetsByKind(petShop);
                        break;

                    case "6":
                        Search(petShop);
                        break;
                }

                if (userChoice == "0")
                {
                    break;
                }
            }
        }

        private static void Search(PetShop petShop)
        {
            Console.Clear();

            Console.Write("Please enter pet kind (0-5):");
            int petKind = int.Parse(Console.ReadLine());

            Console.Write("Please enter pet age state (0-2):");
            int ageState = int.Parse(Console.ReadLine());

            Console.Write("Please enter pet name:");
            string name = Console.ReadLine();

            var searchResult = petShop.Search((AnimalKind)petKind, (AgeState)ageState, name);

            if (searchResult.Count == 0)
            {
                Console.WriteLine("Nothing");
            }

            foreach (var item in searchResult)
            {
                Console.WriteLine(item);
            }

            WaitForKey();
        }

        private static void SellPet(PetShop petShop)
        {
            Console.Write("Please enter pet index:");
            int petIndex = int.Parse(Console.ReadLine());

            var pet = petShop.SellPet(petIndex);

            Console.WriteLine();
            Console.WriteLine($"Sold pet: {pet}");

            WaitForKey();
        }

        private static void ViewPetsByKind(PetShop petShop)
        {
            petShop.OrderByKind();
            petShop.DisplayPets();

            WaitForKey();
        }

        private static void WaitForKey()
        {
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static void AddPet(PetShop petShop)
        {
            Console.Write("Please enter pet name:");
            string petName = Console.ReadLine();

            Console.Write("Please enter pet age:");
            int petAge = int.Parse(Console.ReadLine());

            Console.Write("Please enter pet price:");
            decimal petPrice = decimal.Parse(Console.ReadLine());

            Pet newPet = new Pet { 
                Name = petName,
                Age = petAge,
                Price = petPrice,
            };

            petShop.AddPet(newPet);
        }



        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add new pet");
            Console.WriteLine("2. Sell pet");
            Console.WriteLine("3. View pets by kind");
            Console.WriteLine("4. View pets by age");
            Console.WriteLine("5. View pets by age stage");
            Console.WriteLine("6. Search pet");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please enter your choice (1-6)");

        }
    }
}
