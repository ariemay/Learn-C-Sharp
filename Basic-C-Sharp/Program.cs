using System.Collections.Generic;
using System;

namespace BasicCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i]}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // test
            //var fibonacciNumbers = new List<int> { 1, 1 };
            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //fibonacciNumbers.Add(previous + previous2);

            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);


            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }
    }
}
