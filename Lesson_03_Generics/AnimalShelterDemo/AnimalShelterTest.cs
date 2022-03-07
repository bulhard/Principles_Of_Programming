using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_03_Generics.AnimalShelterDemo
{
    public static class AnimalShelterTest
    {
        public static void RunDogShelter()
        {
            AnimalShelter dogsShelter = new AnimalShelter(10);

            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();

            dogsShelter.Shelter(dog1);
            dogsShelter.Shelter(dog2);
            dogsShelter.Shelter(dog3);

            var myNewDogFromTHeShelter = dogsShelter.Release(1); // Releasing dog2


            Cat cat1 = new Cat();

            var genericAnimalShelter1 = new GenericAnimalShelter<Cat>();

            var genericAnimalShelter2 = new GenericAnimalShelter<Dog>();
        }
    }
}