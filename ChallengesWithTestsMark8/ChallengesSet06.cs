using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;

            var wordsArray = words.ToArray();
            
            if (ignoreCase)
            {
                int i = 0;
                foreach (var item in wordsArray)
                {
                    if (item != null)
                    {
                        wordsArray[i] = item.ToLower();
                    }
                    i++;
                }

                if (wordsArray.Contains(word.ToLower())) return true;
                else
                {
                    return false;
                }
            }
            else if (wordsArray.Contains(word)) return true;
            else return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2 || num == 3 || num == 5) return true;
            if (num > 1)
            {
                if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var uniqueLetterIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    uniqueLetterIndex = i;
                }
            }
            return uniqueLetterIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var maxCount = 1;
            var count = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {                    
                    count = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) return Array.Empty<double>();
            var nthElementList = new List<double>();

            for (int i = n-1; i < elements.Count; i+=n)
            {
                nthElementList.Add(elements[i]);
            }
            return nthElementList.ToArray();
        }
    }
}
