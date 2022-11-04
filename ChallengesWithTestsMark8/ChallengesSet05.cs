using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //for businesses with Business.TotalRevenue = 0, Name = CLOSED
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                //number to be tested as even = [i-1], numbers that follow the even = [i]
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null || words.Length == 0)
            {
                return "";
            }
            foreach(string word in words)
            {
                if(word.Trim().Length > 0)
                {
                    sentence += (word.Trim() + " ");
                }
            }
            if (sentence.Length == 0) 
            { 
                return "";
            }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
                    
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> everyFourthElement = new List<double>();

            for(int index = 3; index < elements.Count; index+=4)
            {
                everyFourthElement.Add(elements[index]);
            }
            return (everyFourthElement.ToArray());
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                //double loop to compare two nums
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}