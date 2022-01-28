using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};


            // IEnumerable<string> LFruits = fruits.Where(singleFruit => singleFruit.Contains("L")).ToList();
            // foreach (var fruit in LFruits)
            // {
            //    Console.WriteLine($"Best Fruits{fruit} "); 
            // }
            
// Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            //    {
            //        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //     };

            // IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
            // Console.WriteLine(fourSixMultiples);

//             List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// IEnumerable<string> sorted = names.OrderByDescending(name => name);
// Console.WriteLine(sorted);
//  


// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };
// IEnumerable<int> sorted = numbers.OrderBy(n => n);
// Console.WriteLine(sorted);

// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };
//  int amount = numbers.Count();
//  Console.WriteLine(amount);

// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// double Total = purchases.Sum(n => n);
// Console.WriteLine(Total);

// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

// double Max = prices.Max(n => n);
// Console.WriteLine(Max);

// List<int> wheresSquaredo = new List<int>()
//             {
//                 66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
//             };
//             // double result = Math.Sqrt(numberToCheck);
//             List<int> wheresSquaredonot = wheresSquaredo.TakeWhile((n) => (Math.Sqrt(n))% 1 != 0).ToList();

            
//             foreach(int number in wheresSquaredonot){
//                 Console.WriteLine(number);
//             }

        // (Math.Sqrt(n))% 1 == 0).ToList();  should be (Math.Sqrt(n))% 1 != 0).ToList();

        
        }       
        }
}
