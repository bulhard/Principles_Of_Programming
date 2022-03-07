using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_03_Generics.AnimalShelterDemo
{
    public class GenericAnimalShelter<TAnimal>
    {
        private const int DefaultPlacesCount = 20;
        private TAnimal[] animalList;
        private int usedPlaces;

        public GenericAnimalShelter() : this(DefaultPlacesCount)
        { }

        public GenericAnimalShelter(int placesCount)
        {
            animalList = new TAnimal[placesCount];
            usedPlaces = 0;
        }

        public void Shelter(TAnimal newAnimal)
        {
            if (usedPlaces >= animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            animalList[usedPlaces] = newAnimal;
            usedPlaces++;
        }

        public TAnimal Release(int index)
        {
            if (index < 0 || index >= usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            TAnimal releasedAnimal = animalList[index];
            for (int i = index; i < usedPlaces - 1; i++)
            {
                animalList[i] = animalList[i + 1];
            }

            animalList[usedPlaces - 1] = default(TAnimal);
            usedPlaces--;
            return releasedAnimal;
        }
    }
}
