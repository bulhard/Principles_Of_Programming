using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_Generics.Task01_GenericList
{
    public class GenericListTest
    {
        public static void Run()
        {
            GenericList<int> genericList = new GenericList<int>(5);

            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);
            genericList.Add(6);
            genericList.Add(7);

            genericList.Insert(111, 0);

            var item1 = genericList.GetItemByIndex(2);

            genericList.RemoveItemByIndex(2);

            var item2 = genericList.GetItemByIndex(2);

            var item3 = genericList.SearchByValue(4);
        }
    }
}
