using static System.Console;
using static Data_Structures_and_Algorithms.TowersOfHanoi;
using static Data_Structures_and_Algorithms.Factorial;
using static Data_Structures_and_Algorithms.FibonacciRegular;
using static Data_Structures_and_Algorithms.FibonacciWithCaching;
using static Data_Structures_and_Algorithms.BinarySearch;
using static Data_Structures_and_Algorithms.Sorting;
using Data_Structures_and_Algorithms;
using System.Diagnostics;
namespace Data_Structures_and_Algorithms
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            TestTowersOfHanoi();

            TestFactorial();

            TestFibonacci();

            TestCachedFibonacci();

            TestDeckOfCards();

            TestBinarySearch();

            TestSorting();  
        }
        static void TestTowersOfHanoi()
        {
            // Towers of Hanoi
            WriteLine("Towers of Hanoi:");
            int[] towers = new int[4] { 1, 2, 3, 4 };
            SolveTower(towers, "C", "B", "A");
        }

        static void TestFactorial()
        {
            // Factorial
            WriteLine();
            WriteLine("Factorial:");

            WriteLine($"10! = {FactorialOf(10)}");
            WriteLine($"5! = {FactorialOf(5)}");
        }

        static void TestFibonacci()
        {
            // Fibonacci
            WriteLine();
            WriteLine("Regular Fibonacci:");
            Stopwatch sw = Stopwatch.StartNew();

            sw.Start();
            ulong fib30 = Fibonacci(30);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 30th fibonacci number: {fib30}");

            sw.Restart();
            ulong fib40 = Fibonacci(40);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 40th fibonacci number: {fib40}");

            /* Commented out due to the time it takes to run the below code
            sw.Restart();
            ulong fib50 = Fibonacci(50);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 50th fibonacci number: {fib50}");

            sw.Restart();
            ulong fib60 = Fibonacci(60);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 50th fibonacci number: {fib60}");
            */
        }

        static void TestCachedFibonacci()
        {
            Stopwatch sw = Stopwatch.StartNew();
            // Memorization
            WriteLine();
            WriteLine("Cached Fibonacci:");

            sw.Start();
            ulong cFib30 = CachedFibonacci(30);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 30th fibonacci number: {cFib30}");

            sw.Restart();
            ulong cFib40 = CachedFibonacci(40);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 40th fibonacci number: {cFib40}");

            sw.Restart();
            ulong cFib50 = CachedFibonacci(50);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 50th fibonacci number: {cFib50}");

            sw.Restart();
            ulong cFib60 = CachedFibonacci(60);
            sw.Stop();
            WriteLine($"It took {sw.Elapsed} to calculate the 50th fibonacci number: {cFib60}");
        }

        static void TestDeckOfCards()
        {
            // Deck of cards
            WriteLine();
            WriteLine("Deck of Cards:");
            Deck cards = new Deck();
            WriteLine("Shuffling Deck");
            cards.Shuffle();
            WriteLine("Top four cards:");
            cards.PrintTopFour();
        }

        static void TestBinarySearch()
        {
            // Binary Search
            WriteLine();
            WriteLine("Binary Search:");
            int[] findArr = new int[5] { 5, 6, 7, 8, 9 };
            WriteLine($"Searching for 5 in [{String.Join(", ", findArr)}] yielded: {Search(5, findArr)}");

            findArr = new int[5] { 1, 2, 5, 8, 9 };
            WriteLine($"Searching for 5 in [{String.Join(", ", findArr)}] yielded: {Search(5, findArr)}");

            findArr = new int[5] { 1, 2, 3, 5, 9 };
            WriteLine($"Searching for 5 in [{String.Join(", ", findArr)}] yielded: {Search(5, findArr)}");

            findArr = new int[5] { 1, 2, 3, 6, 9 };
            WriteLine($"Searching for 5 in [{String.Join(", ", findArr)}] yielded: {Search(5, findArr)}");
        }

        static void TestSorting()
        {
            // Sorting
            WriteLine();
            WriteLine("Selection Sort:");
            int[] sortArr = new int[9] { 5, 17, -4, 5, 6, 21, 100, -98, 1 };
            WriteLine($"Selection sorting [{String.Join(", ", sortArr)}] yielded: [{String.Join(", ", SelectionSort(sortArr))}]");
            WriteLine("Insertion Sort:");
            sortArr = new int[10] { 19, 1, -443, 543, 36, -98, 121, 190, -98, 1 };
            WriteLine($"Insertion sorting [{String.Join(", ", sortArr)}] yielded: [{String.Join(", ", InsertionSort(sortArr))}]");
        }
    }
}
