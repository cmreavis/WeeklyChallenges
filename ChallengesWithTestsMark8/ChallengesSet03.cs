using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                    return true;
            }return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var charLower = false;
            var charUpper = false;
            var charNumber = false;

            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    charLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    charUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    charNumber = true;
                }
            }
            if (charLower == true && charUpper == true && charNumber == true)
            {
                return true;
            }return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var firstLetter = val.First();
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val.Last();
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        { 
            if (divisor == 0.0M || dividend == 0.0M) 
            {
                return 0;
            }
            return (dividend / divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            var lastInt = nums.Last();
            var firstInt = nums.First();
            return (lastInt - firstInt);
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNums = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNums.Add(i);
                }
            }return oddNums.ToArray();
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
