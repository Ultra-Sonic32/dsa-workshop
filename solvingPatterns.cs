using System;

namespace DSAWorkshop
{
    public static class FrequencyPattern
    {
        // The function should return true if every value in the array has its corresponding value squared in the second array
        public static bool sameSquared(int[] values, int[] squares)
        {
            Dictionary<int, int> valueCounts = new Dictionary<int, int>();
            Dictionary<long, int> squareCounts = new Dictionary<long, int>();

            if (values.Length != squares.Length) return false;

            for (int i = 0; i < values.Length; i++)
            {
                valueCounts[values[i]] = valueCounts.GetValueOrDefault(values[i]) + 1;
            }

            for (int j = 0; j < squares.Length; j++)
            {
                squareCounts[squares[j]] = squareCounts.GetValueOrDefault(squares[j]) + 1;
            }

            foreach (var key in valueCounts)
            {
                long squared = Convert.ToInt32(Math.Pow(key.Key, 2));
                if (!squareCounts.ContainsKey(squared)) return false;
                if (squareCounts.ContainsKey(squared) != valueCounts.ContainsKey(key.Key)) return false;
            }

            return true;
        }

        // Function to test if two string are anagrams of eachother
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> sCount = new Dictionary<char, int>();
            Dictionary<char, int> tCount = new Dictionary<char, int>();

            if (s.Length != t.Length) return false;

            for (int i = 0; i < s.Length; i++)
            {
                sCount[s[i]] = sCount.GetValueOrDefault(s[i]) + 1;
                tCount[t[i]] = tCount.GetValueOrDefault(t[i]) + 1;
            }

            foreach (var kvp in sCount)
            {
                if (!tCount.ContainsKey(kvp.Key) || tCount[kvp.Key] != kvp.Value) return false;
            }

            return true;
        }

    }

    public static class MultiPointerPattern
    {

        // Function which accepts a sorted array of integers. The function should find the first pair where the sum is 0;
        // return array of values that sum to zero or undefined if no pair
        //The naive approach is using a nested for loop and not two pointers
        public static int[]? sumZeroNaive(int[] sortedIntegers)
        {
            if (sortedIntegers is null || sortedIntegers.Length < 2) return null;

            int[] pair = new int[2];

            for (int i = 0; i < sortedIntegers.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedIntegers.Length; j++)
                {
                    if (sortedIntegers[i] + sortedIntegers[j] == 0)
                    {
                        return new[] { sortedIntegers[i], sortedIntegers[j] };
                    }
                }
            }

            return null;
        }

        public static int[]? sumZeroTwoPointer(int[] sortedIntegers)
        {
            int left = 0;
            int right = sortedIntegers.Length - 1;

            while (left < right)
            {
                int sum = sortedIntegers[left] + sortedIntegers[right];

                if (sum == 0)
                {
                    return new[] { sortedIntegers[left], sortedIntegers[right] };
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return null;
        }

        public static int countUniqueValues(int[] sortedIntegers) {
            
        }
    }
}