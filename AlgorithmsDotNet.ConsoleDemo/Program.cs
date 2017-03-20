using System;
using System.Linq;

namespace AlgorithmsDotNet.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedIntegerArray = { 29, 27, 20, 28, 24, 26, 9, 7, 10, 8, 4, 6, 21, 22, 25, 23, 1, 2, 5, 3 };
            string[] unsortedStringArray = { "halt", "plane", "train", "analyzed", "HAL", "oddesey", "brakes", "mobile", "analyzing", "halted", "be rigth back", "123 Street" };

            // Insertion sort on integer array
            var runInsertionSortOnIntegerArrayResult = RunInsertionSortOnIntegerArray(unsortedIntegerArray.ToArray());

            runInsertionSortOnIntegerArrayResult.Item1.ToList().ForEach(Console.WriteLine);

            Console.WriteLine(runInsertionSortOnIntegerArrayResult.Item2);

            Console.WriteLine(string.Empty);

            // Insertion sort on string array
            var runInsertSortOnStringArrayResult = RunInsertionSortOnStringArray(unsortedStringArray.ToArray());

            runInsertSortOnStringArrayResult.Item1.ToList().ForEach(Console.WriteLine);

            Console.WriteLine(runInsertSortOnStringArrayResult.Item2);

            Console.WriteLine(string.Empty);

            // Bubble sort on integer array
            var runBubbleSortOnIntegerArrayResult = RunBubbleSortOnIntegerArray(unsortedIntegerArray.ToArray());

            runBubbleSortOnIntegerArrayResult.Item1.ToList().ForEach(Console.WriteLine);

            Console.WriteLine(runBubbleSortOnIntegerArrayResult.Item2);
        }

        static Tuple<int[], string> RunInsertionSortOnIntegerArray(int[] unsortedArray)
        {
            var startDateTime = DateTime.Now;

            unsortedArray.InsertionSort((a, b) => (a > b));

            var endDateTime = DateTime.Now;

            var elapsed = endDateTime - startDateTime;

            string resultMessage = $"*** Elapsed: {elapsed.Milliseconds.ToString()} ms";

            return Tuple.Create(unsortedArray, resultMessage);
        }

        static Tuple<string[], string> RunInsertionSortOnStringArray(string[] unsortedArray)
        {
            var startDateTime = DateTime.Now;

            unsortedArray.InsertionSort((a, b) => string.Compare(a, b, StringComparison.CurrentCulture) > 0);

            var endDateTime = DateTime.Now;

            var elapsed = endDateTime - startDateTime;

            string resultMessage = $"*** Elapsed: {elapsed.Milliseconds.ToString()} ms";

            return Tuple.Create(unsortedArray, resultMessage);
        }

        static Tuple<int[], string> RunBubbleSortOnIntegerArray(int[] unsortedArray)
        {
            var startDateTime = DateTime.Now;

            unsortedArray.BubbleSort((a, b) => (a > b));

            var endDateTime = DateTime.Now;

            var elapsed = endDateTime - startDateTime;

            string resultMessage = $"*** Elapsed: {elapsed.Milliseconds.ToString()} ms";

            return Tuple.Create(unsortedArray, resultMessage);
        }
    }
}