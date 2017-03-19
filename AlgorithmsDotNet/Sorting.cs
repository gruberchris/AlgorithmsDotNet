using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDotNet
{
    public static class Sorting
    {
        public static T[] InsertionSort<T> (this T[] collection, Func<T, T, bool> compare)
        {
            for (var count = 0; count < collection.Count() - 1; count++)
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

            return collection;
        }
    }
}
