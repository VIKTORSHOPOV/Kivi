using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivi
{
    public class Logic
    {
        public static bool AABB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            // Create a dictionary to count occurrences of each number
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Count occurrences of each number in the list
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            // Check if at least 2 numbers have a count of 2 or more
            int countOfAtLeastTwo = 0;
            foreach (var kvp in counts)
            {
                if (kvp.Value >= 2)
                {
                    countOfAtLeastTwo++;
                }
            }

            return countOfAtLeastTwo >= 2;
        }
        public static bool ABCDE(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            // Use LINQ distinct method to get distinct values
            var distinctValues = numbers.Distinct();

            // If the count of distinct values is 5, then there are 5 different values
            return distinctValues.Count() == 5;
        }
        public static bool SumIsLessThanOrEqualTo12(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum <= 12;
        }
        public static bool AAA(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            return numbers.GroupBy(x => x).Any(g => g.Count() >= 3);
        }
        public static bool AllValuesAreOdd(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            bool allOdd = true;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    allOdd = false;
                    break;
                }
            }
            return allOdd;
        }
        public static bool AllValuesAreEven(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            bool allOdd = true;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    allOdd = false;
                    break;
                }
            }
            return allOdd;
        }
        public static bool AAAABB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            int fourOfAKindCount = countMap.Count(kv => kv.Value == 4);
            int twoPairsCount = countMap.Count(kv => kv.Value == 2);

            // Check if there's exactly one number occurring four times and exactly two numbers occurring two times
            return fourOfAKindCount == 1 && twoPairsCount == 1;
        }
        public static bool AABBCC(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            // Count how many numbers have a count of 2
            int pairCount = countMap.Count(kv => kv.Value == 2);

            // Check if there are exactly three pairs
            return pairCount == 3;
        }
        public static bool ABCD(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            // Use LINQ Distinct to get distinct values
            var distinctValues = numbers.Distinct();

            // Check if there are exactly 4 distinct values
            return distinctValues.Count() == 4;
        }
        public static bool AAABBB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            // Count how many numbers have a count of 2
            int twoCount = countMap.Count(kv => kv.Value == 2);

            // Check if there are exactly 3 numbers occurring twice
            return twoCount == 3;
        }
        public static bool SumIsGreaterThanOrEqualTo30(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum >= 30;
        }
        public static bool AAAA(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            // Check if any number occurs four times
            return countMap.Any(kv => kv.Value == 4);
        }
        public static bool AAABB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            // Count how many numbers have a count of 3 and how many have a count of 2
            int threeCount = countMap.Count(kv => kv.Value == 3);
            int twoCount = countMap.Count(kv => kv.Value == 2);

            // Check if there's exactly one number occurring three times and exactly two numbers occurring two times
            return threeCount == 1 && twoCount == 2;
        }
    }
}
