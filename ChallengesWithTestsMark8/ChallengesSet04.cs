using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {                        
            var stringLengthList = new List<int>();

            stringLengthList.Add(str1.Count<char>());
            stringLengthList.Add(str2.Count<char>());
            stringLengthList.Add(str3.Count<char>());
            stringLengthList.Add(str4.Count<char>());

            stringLengthList.Sort();

            return stringLengthList[0];
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberArray = new int[] { number1, number2, number3, number4 };
            Array.Sort(numberArray);
            return numberArray[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3)
            {
                if (sideLength1 + sideLength3 > sideLength2)
                {
                    if (sideLength2 + sideLength3 > sideLength1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double x;
            return double.TryParse(input, out x);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int totalArrayLength = objs.Length;
            int totalNullElements = 0;
            foreach (var objt in objs)
            {
                if (objt == null)
                {
                    totalNullElements++;
                }
            }
            return totalNullElements > (totalArrayLength - totalNullElements);
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null) return 0;

            var evensList = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evensList.Add(num);
                }
            }
            
            if(evensList.Count == 0) return 0;
            return evensList.Average();            
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
