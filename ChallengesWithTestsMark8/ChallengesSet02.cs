using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c)) return true;
            return false;
        }
        
        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;
            if (count % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) return true;
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {            
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0) return true;
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null) return 0;

            long count = 0;
            for (long i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }                
            }
            return count;
        }
    }
}
