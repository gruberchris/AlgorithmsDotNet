using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDotNet
{
    public static class Sorting
    {
        public static void InsertionSort<T> (this T[] collection, Func<T, T, bool> compare)
        {
            for (var count = 0; count < collection.Length - 1; count++)
            {
                var nextElement = count + 1;

                while (nextElement > 0)
                {
                    if (compare(collection[nextElement - 1], collection[nextElement]))
                    {
                        var swappingElement = collection[nextElement - 1];

                        collection[nextElement - 1] = collection[nextElement];
                        collection[nextElement] = swappingElement;
                    }

                    nextElement--;
                }
            }
        }

        public static void BubbleSort<T>(this T[] collection, Func<T, T, bool> compare)
        {
            var swapped = true;

            do
            {
                swapped = false;

                for (var count = 0; count < collection.Length - 1; count++)
                {
                    if (!compare(collection[count], collection[count + 1])) continue;

                    var swappingElement = collection[count];

                    collection[count] = collection[count + 1];
                    collection[count + 1] = swappingElement;
                    swapped = true;
                }
            } while (swapped);
        }
    }
}
