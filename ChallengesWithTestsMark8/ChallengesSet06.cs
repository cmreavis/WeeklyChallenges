using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var containsWord = false;
            if(Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word.ToLower();
                List<string> strings = words.Select(x => x.ToLower()).ToList();
                containsWord = strings.Contains(word);
            }
            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
            if(num >= 0)
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if(num == 1)
            {
                isPrime = false;
            }
            if((num == 2) || (num == 3))
            {
                isPrime = true;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            for(int i = 0; i < str.Length; i++)
            {
                var unique = true;

                for(int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x] && i != x)
                    {
                        unique = false;
                    }
                }
                if(unique == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                int newCount = 1;

                {
                    for(int x = i + 1; x < numbers.Length; x++)
                    {
                        if (numbers[i] != numbers[x])
                        {
                            break;
                        }
                        newCount++;
                    }
                    if(newCount > count)
                    {
                        count = newCount;
                    }
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> element = new List<double>();
            double[] bonk = new double[0];

            //returns an array just to check for null
            if(elements == null)
            {
                return bonk;
            }

            for(int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    element.Add(elements[i]);
                }
                if(n < 0 || n > elements.Count)
                {
                    //clears the list
                    element.Clear();
                }
            }
            //list to array
            double[] result = element.ToArray();
            return result;
        }
    }
}
