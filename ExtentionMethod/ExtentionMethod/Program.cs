using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> numbers = new List<int> { 0, 1, 2, 2, 3, 3, 3, 8, 9, 3, 9, 4, 5, 6, 0, 0, 22, 32, 150, 149 };
            List<int> newNumbers = new List<int> { };
            numbers.ShowUnique(newNumbers);
        }
    }

    public static class ListExtention
    {

        public static IEnumerable<int> ShowUnique(this IEnumerable<int> list, IEnumerable<int> uniqueNumbers)
        {
            uniqueNumbers = list.Distinct();
            foreach (int i in uniqueNumbers)
            {
                Console.WriteLine(i);
            }
            return uniqueNumbers;
            
        }
    }
}

