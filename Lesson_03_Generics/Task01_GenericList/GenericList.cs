using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_Generics.Task01_GenericList
{
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] data;
        private int dataIndex;

        public GenericList(int initialSize)
        {
            data = new T[initialSize];
            dataIndex = 0;
        }

        public void Add(T newItem)
        {
            IncreaseCapacityIfNeeded();

            data[dataIndex] = newItem;
            dataIndex++;
        }

        public void Insert(T newItem, int position)
        {
            IncreaseCapacityIfNeeded();

            for (int i = dataIndex; i > position - 1; i--)
            {
                data[i + 1] = data[i];
            }

            data[position] = newItem;
            dataIndex++;
        }

        public T GetItemByIndex(int index)
        {
            if (index < 0 || index >= dataIndex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataIndex);
            }
            return data[index];
        }

        public void RemoveItemByIndex(int index)
        {
            if (index < 0 || index >= dataIndex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataIndex);
            }

            for (int i = index; i < dataIndex - 1; i++)
            {
                data[i] = data[i + 1];
            }

            data[dataIndex - 1] = default;

            dataIndex--;
        }

        // https://www.bestprog.net/en/2021/07/29/c-comparison-of-instances-of-generic-types/#q01
        public T SearchByValue(T valueToSearch)
        {
            foreach (var item in data)
            {
                if (item.CompareTo(valueToSearch) == 0)
                {
                    return item;
                }
            }
            return default;
        }

        public void IncreaseCapacityIfNeeded()
        {
            if (dataIndex >= data.Length)
            {
                T[] resizedArray = new T[data.Length * 2];

                Array.Copy(data, 0, resizedArray, 0, data.Length);

                data = resizedArray;
            }
        }
    }
}
