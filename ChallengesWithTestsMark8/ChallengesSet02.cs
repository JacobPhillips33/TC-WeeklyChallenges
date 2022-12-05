using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }
        
        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() < 1 ? 0 : numbers.Min(x => x) + numbers.Max(x => x);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length <= str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum(x => x);
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum(x => x % 2 == 0 ? x : 0);
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : numbers.Sum(x => x) % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number == null || number < 0 ? 0 : number / 2;
        }
    }
}
