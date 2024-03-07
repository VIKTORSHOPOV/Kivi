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

            Dictionary<int, int> counts = new Dictionary<int, int>();


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


            int countOfAtLeastTwo = 0;
            foreach (var kvp in counts)
            {
                if (kvp.Value >= 2)
                {
                    countOfAtLeastTwo++;
                }
            }

            return countOfAtLeastTwo >= 2;
        } //works
        public static bool ABCDE(List<int> numbers)//works
        {
            if (numbers.Count == 0)
                return false;

            var distinctValues = numbers.Distinct();


            return distinctValues.Count() >= 5;
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
        } //works
        public static bool AAA(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            return numbers.GroupBy(x => x).Any(g => g.Count() >= 3);
        } //works
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
        }//works
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
        } //works
        public static bool AAAABB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            int fourOfAKindCount = countMap.Count(kv => kv.Value == 4);
            int twoPairsCount = countMap.Count(kv => kv.Value == 2);


            return fourOfAKindCount == 1 && twoPairsCount == 1;
        }//works
        public static bool AABBCC(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }


            int pairCount = countMap.Count(kv => kv.Value == 2);


            return pairCount == 3;
        }//works
        public static bool ABCD(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;

            var distinctValues = numbers.Distinct();


            return distinctValues.Count() >= 4;
        }//works
        public static bool AAABBB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }


            int threeCount = countMap.Count(kv => kv.Value == 3);


            return threeCount == 2;

        }//works
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
        }//works
        public static bool AAAA(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }


            return countMap.Any(kv => kv.Value >= 4);
        }//works
        public static bool AAABB(List<int> numbers)
        {
            if (numbers.Count == 0)
                return false;
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }


            int threeCount = countMap.Count(kv => kv.Value == 3);
            int twoCount = countMap.Count(kv => kv.Value == 2);


            return threeCount >= 1 && twoCount >= 1;
        } //works
    }
}
