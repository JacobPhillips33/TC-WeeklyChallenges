using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false)) return true;
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null) return false;

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            if (sum % 2 == 0) return false;
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null) return false;
            
            bool upper = false;
            foreach (var character in password)
            {
                if (Char.IsUpper(character))
                {
                    upper = true;
                    break;
                }
            }

            bool lower = false;
            foreach (var character in password)
            {
                if (Char.IsLower(character))
                {
                    lower = true;
                    break;
                }
            }

            bool number = false;
            foreach (var character in password)
            {
                if (Char.IsNumber(character))
                {
                    number = true;
                    break;
                }
            }

            if (upper == true && lower == true && number == true) return true;
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {            
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];        }

        public int[] GetOddsBelow100()
        {            
            var oddsBelow100 = new List<int>();
            for (int i = 1; i < 100; i+=2)
            {
                oddsBelow100.Add(i);
            }
            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
