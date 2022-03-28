using Lesson_06_PetShop.Entities;
using Lesson_06_PetShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_PetShop.Core
{
    public class PetShop
    {
        private Pet[] pets;
        private int emptyIndex = 0;

        public PetShop(int limit)
        {
            pets = new Pet[limit];
        }

        public Pet SellPet(int petIndex)
        {
            var chosenPet = pets[petIndex];

            for (int i = petIndex; i < pets.Length - 1; i++)
            {
                pets[i] = pets[i + 1];
            }
            emptyIndex--;

            pets[pets.Length - 1] = null;

            return chosenPet;
        }

        public void AddPet(Pet newPet)
        {
            if (emptyIndex < pets.Length)
            {
                pets[emptyIndex] = newPet;
                emptyIndex++;
            }
        }

        public void GeneratePets()
        {
            Random rnd = new Random();

            for (int i = 0; i < pets.Length; i++)
            {
                pets[i] = new Pet
                {
                    Name = $"Pet {i}",
                    Age = rnd.Next(1, 100),
                    MaxAge = 100,
                    Price = (decimal)rnd.NextDouble() * 200,
                    Quantity = rnd.Next(10, 200),
                    Kind = (AnimalKind)rnd.Next(0, 6)
                };
                emptyIndex++;
            }
        }

        public void DisplayPets()
        {
            Console.Clear();

            for (int i = 0; i < pets.Length; i++)
            {
                if (pets[i] == null)
                {
                    Console.WriteLine("n/a");
                }
                else
                {
                    Console.WriteLine(pets[i]);
                }
            }
        }

        public List<Pet> Search(AnimalKind kind, AgeState ageState, string name)
        {
            List<Pet> searchResult = new List<Pet>();

            foreach (var pet in pets)
            {
                if (pet.Kind == kind && pet.AgeState == ageState && pet.Name.Contains(name))
                {
                    searchResult.Add(pet);
                }
            }

            return searchResult;
        }

        public void OrderByKind()
        {
            for (int i = 0; i < pets.Length; i++)
            {
                for (int j = 0; j < pets.Length; j++)
                {
                    if (pets[i].Kind < pets[j].Kind)
                    {
                        var temp = pets[i];
                        pets[i] = pets[j];
                        pets[j] = temp;
                    }
                }
            }
        }
    }
}
