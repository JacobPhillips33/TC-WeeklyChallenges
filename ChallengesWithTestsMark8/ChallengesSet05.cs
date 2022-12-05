using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while(startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0) biz.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) return false;

            for (int i = 0; i < numbers.Length - 1; i++)
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
            if(numbers == null) return 0;

            var sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i - 1] % 2 == 0 ? numbers[i] : 0;
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length < 1) return "";

            var sentence = "";
            foreach (var word in words)
            {
                if (word.Any(char.IsLetter)) 
                {
                    sentence += word.Trim() + " ";
                }
            }            

            sentence = sentence.Trim();
            return sentence == "" ? "" : sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourthElement = new List<double>();
            if (elements == null) return fourthElement.ToArray();

            for (int i = 3; i < elements.Count; i+=4)
            {
                fourthElement.Add(elements[i]);
            }

            return fourthElement.ToArray();
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
