using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            foreach (var num in numbers)
            {
                answer += num % 2 == 0 ? num : -num;
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var numArray = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return numArray.Min(x => x);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numArray = new int[] {number1, number2, number3, number4};
            return numArray.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                   sideLength1 + sideLength3 > sideLength2 &&
                   sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Length/2 < objs.Where(x => x == null).Count();
        }

        public double AverageEvens(int[] numbers)
        {
            return numbers == null || numbers.Length < 1 ? 0 : numbers.Where(x => x % 2 == 0).Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            var factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
