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
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

            if (sum % 2 == 0) return false;
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
        }

            if (upper == true && lower == true && number == true) return true;
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
           return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var answer = new int[100 / 2];
            var j = 0;
            for (int i = 1; i < 100; i+=2)
            {
                answer[j] = i;
                j++;
            }
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            var i = 0;
            foreach (var word in words)
            {
                words[i] = word.ToUpper();
                i++;
            }
        }
    }
}
