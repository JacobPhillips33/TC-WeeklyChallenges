using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int answer = 0;
            for (int i = startNumber+1; i >= startNumber; i++)
            {                
                if (i % n == 0)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var company in businesses)
            {
                if (company.TotalRevenue == 0)
                {
                    company.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1) return false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    for (int j = i+1; j < numbers.Length; j++)
                    {
                        sum += numbers[j];
                        break;
                    }
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var joinedString = "";
            if (words == null || words.Length < 1) return "";
            foreach (var word in words)
            {
                joinedString += $" {word.Trim()}";
                joinedString = joinedString.Trim();
            }            
            
            if (joinedString.Length < 1) return "";
            return $"{joinedString}.";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {            
            if (elements == null) return Array.Empty<double>();
            var forthElementList = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                forthElementList.Add(elements[i]);
            }
            return forthElementList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
