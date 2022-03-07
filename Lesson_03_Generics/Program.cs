using Lesson_03_Generics.AnimalShelterDemo;
using Lesson_03_Generics.Task01_GenericList;
using System;

namespace Lesson_03_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // AnimalShelterTest.RunDogShelter();


            #region Swap Demo
            //int a1 = 1;
            //int b1 = 2;

            //SwapDemo.Swap<int>(ref a1, ref b1);

            //string a2 = "1";
            //string b2 = "2";

            //SwapDemo.Swap<string>(ref a2, ref b2);

            #endregion

            #region GenericListTest

            GenericListTest.Run();

            #endregion
        }
    }
}
