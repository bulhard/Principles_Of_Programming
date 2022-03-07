using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_Generics.AnimalShelterDemo
{
    public class AnimalShelter
    {
        private const int DefaultPlacesCount = 20;
        private Dog[] animalList;
        private int usedPlaces;

        public AnimalShelter() : this(DefaultPlacesCount)
        { }

        public AnimalShelter(int placesCount)
        {
            animalList = new Dog[placesCount];
            usedPlaces = 0;
        }

        public void Shelter(Dog newAnimal)
        {
            if (usedPlaces >= animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            animalList[usedPlaces] = newAnimal;
            usedPlaces++;
        }

        public Dog Release(int index)
        {
            if (index < 0 || index >= usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            Dog releasedAnimal = animalList[index];
            for (int i = index; i < usedPlaces - 1; i++)
            {
                animalList[i] = animalList[i + 1];
            }

            animalList[usedPlaces - 1] = null;
            usedPlaces--;
            return releasedAnimal;
        }
    }
}