using System;
using System.Diagnostics;

namespace DSAWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Measure performance
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Choose a problem to run:");
            Console.WriteLine("1. Reverse String");
            Console.WriteLine("2. Sum Value");
            Console.WriteLine("3. Count Alphanumeric Characters");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a string");
                    string? s = Console.ReadLine();
                    Console.WriteLine(ReverseString.RerverseWithArray(s));
                    break;
                
                case  "2":
                    Console.WriteLine("Enter the number to sum up to");
                    int n = int.Parse(Console.ReadLine() ?? "0");
                    stopwatch.Start();
                    Console.WriteLine(SumValues.AddUpTo(n));
                    //Console.WriteLine(SumValues.AddUpToOptimised(n));
                    stopwatch.Stop();
                    TimeSpan elapsedTimeSpan = stopwatch.Elapsed;
                    Console.WriteLine($"Elapsed time (TimeSpan): {elapsedTimeSpan.TotalMilliseconds} milliseconds");
                    break;  
                
                case "3":
                    Console.WriteLine("Enter a string");
                    string? input = Console.ReadLine();
                    var result = countCharacterString.countAlphanumericCharacters(input);
                    foreach (var kvp in result)
                    {
                        Console.WriteLine($"Key: {kvp.Key}: Value: {kvp.Value}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            
        }
    }
}