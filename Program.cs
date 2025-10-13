using System;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;

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
            Console.WriteLine("4. Value array and corresponding squared array matches");
            Console.WriteLine("5. Is Valid Anagram");
            Console.WriteLine("6. SumZero");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a string");
                    string? s = Console.ReadLine();
                    Console.WriteLine(ReverseString.RerverseWithArray(s));
                    break;

                case "2":
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

                case "4":
                    int[]? valueArray = ReadIntArrayFromConsole("Enter Values like 1,2,3");
                    int[]? squareArray = ReadIntArrayFromConsole("Enter squares like 1,4,9");
                    bool ok = FrequencyPattern.sameSquared(valueArray, squareArray);
                    Console.WriteLine(ok ? "Matched" : "Invalid");
                    break;
                
                case "5":
                    Console.WriteLine("Enter a first string");
                    string? firstString = Console.ReadLine();
                    Console.WriteLine("Enter a second string");
                    string? secondString = Console.ReadLine();
                    bool isAnagram = FrequencyPattern.IsAnagram(firstString, secondString);
                    Console.WriteLine(isAnagram ? "Valid Anagram" : "Not an Anagram");
                    break;
                
                case "6":
                    int[]? sortedValueArray = ReadIntArrayFromConsole("Enter Sorted Array like -1, -2, 0, 1, 3");
                    var pair = MultiPointerPattern.sumZeroNaive(sortedValueArray);
                    Console.WriteLine(pair is null ? "No pair" : $"[{pair[0]}, {pair[1]}]");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
        
         private static int[] ReadIntArrayFromConsole(string prompt)
        {
            Console.WriteLine(prompt);
            string? line = Console.ReadLine();
            return ParseIntArray(line);
        }

        private static int[] ParseIntArray(string? line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return Array.Empty<int>();

            // Split by commas and/or whitespace, ignore empties
            string[] parts = line.Split(new[] { ',', ' ', '\t', ';' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<int>(parts.Length);
            foreach (var token in parts)
            {
                if (!int.TryParse(token, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
                    throw new FormatException($"Invalid integer token: '{token}'.");
                list.Add(value);
            }
            return list.ToArray();
        }

    }
}