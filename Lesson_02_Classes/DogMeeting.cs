using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_02_Classes
{
    public static class DogMeeting
    {
        public static void Run()
        {
            string firstDogName = null;
            Console.Write("Enter first dog name: ");
            firstDogName = Console.ReadLine();

            // Using a constructor to create a dog with specified name
            Dog firstDog = new Dog(firstDogName);

            // Using a constructor to create a dog wit a default name
            Dog secondDog = new Dog();
            Console.Write("Enter second dog name: ");
            string secondDogName = Console.ReadLine();

            // Using property to set the name of the dog
            secondDog.Name = secondDogName;

            // Creating a dog with a default name
            Dog thirdDog = new Dog();

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}