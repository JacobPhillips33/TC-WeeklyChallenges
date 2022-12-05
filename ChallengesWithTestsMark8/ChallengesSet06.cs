using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null) return false;
            if (ignoreCase)
            {
                words = words.Select(x => x == null ? "" : x.ToLower());
                return words.Contains(word.ToLower());
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <=0 || num == 1) return false;
            if (num == 2 || num == 3 || num == 5 || num == 7) return true;
            return num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                var newStr = str.Remove(i, 1);
                if (!newStr.Contains(str[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 1;
            var maxCount = 1;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }                    
                    else
                    {
                        break;
                    }                    
                }
                if (count > maxCount) maxCount = count;
                count = 1;
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElements = new List<double>();
            if (n <= 0 || elements == null) return nthElements.ToArray();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElements.Add(elements[i]);
            }
            return nthElements.ToArray();
        }
    }
}
