using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
                return true;

            else return false;


        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //find min and max
            //sum min and max
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return str1.Length;
            else return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (var number in numbers)
            {
                sum += number;
            }
            if (sum >= 0 || sum < 0)
            {
                    return sum;
            }
            return 0;

            

        }

        public int SumEvens(int[] numbers)
        {
            //remove odd numbers from array
            //sum array
            List<int> onlyEvens = new List<int>();
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    onlyEvens.Add(num);
                }
            }
            foreach (int number in onlyEvens)
            {
                sum += number;
            }
            return sum;
        }


        public bool IsSumOdd(List<int> numbers)
        {
            //sum list
            int sum = 0;
            if (numbers == null)
                return false;

            foreach (int number in numbers)
            {
                sum += number;
            }
            //determine if odd
            return (sum % 2 != 0);

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long counter = 0;
            //counter for odd numbers 0 < x < number
            for (long i = number; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
            }return counter;
        }
    }
}
