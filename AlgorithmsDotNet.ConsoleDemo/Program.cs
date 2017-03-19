using System;

namespace AlgorithmsDotNet.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var runInsertionSortOnIntegerArrayResult = RunInsertionSortOnIntegerArray();

            foreach (var i in runInsertionSortOnIntegerArrayResult.Item1)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine(runInsertionSortOnIntegerArrayResult.Item2);

            Console.WriteLine(string.Empty);

            var runInsertSortOnStringArrayResult = RunInsertionSortOnStringArray();

            foreach (string s in runInsertSortOnStringArrayResult.Item1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(runInsertSortOnStringArrayResult.Item2);
        }

        static Tuple<int[], string> RunInsertionSortOnIntegerArray()
        {
            int[] unsortedArray = { 29, 27, 20, 28, 24, 26, 9, 7, 10, 8, 4, 6, 21, 22, 25, 23, 1, 2, 5, 3 };

            var startDateTime = DateTime.Now;

            var sortedArray = unsortedArray.InsertionSort((a, b) => (a > b));

            var endDateTime = DateTime.Now;

            var elapsed = endDateTime - startDateTime;

            string resultMessage = $"*** Elapsed: {elapsed.Milliseconds.ToString()} ms";

            return Tuple.Create(sortedArray, resultMessage);
        }

        static Tuple<string[], string> RunInsertionSortOnStringArray()
        {
            string[] unsortedArray = { "halt", "plane", "train", "analyzed", "HAL", "oddesey", "brakes", "mobile", "analyzing", "halted", "be rigth back", "123 Street" };

            var startDateTime = DateTime.Now;

            var sortedArray = unsortedArray.InsertionSort((a, b) => a.CompareTo(b) > 0);

            var endDateTime = DateTime.Now;

            var elapsed = endDateTime - startDateTime;

            string resultMessage = $"*** Elapsed: {elapsed.Milliseconds.ToString()} ms";

            return Tuple.Create(sortedArray, resultMessage);
        }
    }
}